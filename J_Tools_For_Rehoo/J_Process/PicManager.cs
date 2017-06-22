using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace J_Tools_For_Rehoo.J_Process
{
    public class PicManager
    {
        private const int BYTEREADCOUNT = 1024;
        public PicManager(string FolderPath, string fileOffsetName)
        {
            this.FolderPath = FolderPath;
            this.FileOffsetName = fileOffsetName;
        }

        //要存储的文件夹
        public string FolderPath { get; set; }
        public string FileOffsetName { get; set; }
        //版本号
        public string Version { get; set; }
        //作者
        public string Author { get; set; }
        //标题fontChars
        public string TitleForOffset { get; set; }

        public string BinFileName { get; set; }


        public string DefPrefix { get; set; }

        public bool CreateFile(ListView lv)
        {


            StringBuilder sbOffset = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*" + this.TitleForOffset + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: " + this.FileOffsetName + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");

            StringBuilder sbIconMain = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*                                      主界面所有图标源文件" + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: iconMain.c" + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");

            sbIconMain.Append("#include \"App_Header.h\"\n\r\n\r");

            StringBuilder sbIconSetting = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*                                      设置界面所有图标源文件" + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: iconSetting.c" + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");
            sbIconSetting.Append("#include \"App_Header.h\"\n\r\n\r");

            StringBuilder sbIconGlobal = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*                                      全局资源函数源文件" + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: iconGlobal.c" + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");
            sbIconGlobal.Append("#include \"App_Header.h\"\n\r\n\r");



            sbOffset.Append("#ifndef _" + this.FileOffsetName.ToUpper().Split('.')[0] + "_H\n" +
                       "#define _" + this.FileOffsetName.ToUpper().Split('.')[0] + "_H\n");
            sbOffset.Append("\r\n\r\n");
            sbOffset.Append("#define     Resource_Icon_Addr     (SDRAM_BASE_ADDR+RAM_MAP_RESOURCE_SEG)\n");
            sbOffset.Append("\r\n\r\n");
            FileStream fsWrite = new FileStream(this.FolderPath + "/" + this.BinFileName, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fsWrite);


            long index = 0;
            int iconMainNum = 0, iconSettingNum = 0, iconGlobalNum = 0;

            foreach (ListViewItem item  in lv.Items)
            {
                string fname = item.SubItems[1].Text.Split('.')[1];
                if (fname.ToUpper() == "SIF")
                {

                    sbOffset.Append("#define    RESOURCE_OFFSET_ALL_PICS  " + "    (0x" + index.ToString("X") + ")\n");
                    sbOffset.Append("\r\n\r\n");


                    FileStream fsOpen = new FileStream(item.SubItems[2].Text, FileMode.Open);
                    BinaryReader br = new BinaryReader(fsOpen);

                    for (int i = 0; i < br.BaseStream.Length; i++)
                    {
                        bw.Write(br.ReadByte());
                    }

                    sbOffset.Append("#define    RESOURCE_OFFSET_ALL_FONTS   " + "    (0x" + index.ToString("X") + ")\n");
                    sbOffset.Append("\r\n\r\n");

                    index += br.BaseStream.Length;
                    br.Close();
                    fsOpen.Close();
                       
                }
                else
                {
                    string iconName = item.SubItems[1].Text.Split('.')[0];

                    FileStream fsOpen = new FileStream(this.FolderPath + "/" + iconName + ".h", FileMode.Open);
                    StreamReader sr = new StreamReader(fsOpen);

                    string strTemp = sr.ReadToEnd();

                    if (iconName.ToUpper() == "ICONMAIN")
                    {
                        iconMainNum++;
                    }
                    else if (iconName.ToUpper() == "ICONSETTING")
                    {
                        iconSettingNum++;
                    }
                    else if (iconName.ToUpper() == "ICONGLOBAL")
                    {
                        iconGlobalNum++;
                    }
                    string subStringTemp = strTemp.Substring(strTemp.IndexOf('{') + 1, strTemp.IndexOf('}') - strTemp.IndexOf('{') - 1);
                    subStringTemp = subStringTemp.Replace("0x", null);
                    subStringTemp = subStringTemp.Replace(" ", null);
                    subStringTemp = subStringTemp.Replace("\r\n", null);

                    string[] sptStrings = subStringTemp.Split(',');


                    int Type = 0;
                    for (int i = 0; i < sptStrings.Length; i++)
                    {
                        if (sptStrings[i].Length == 8)
                        {
                            uint myTempR32 = uint.Parse(sptStrings[i], System.Globalization.NumberStyles.HexNumber);

                            bw.Write(myTempR32);
                            Type = 0;
                        }
                        else if (sptStrings[i].Length == 4)
                        {
                            // byte b = byte.Parse(sptStrings[i], System.Globalization.NumberStyles.HexNumber);
                            ushort myTempR16 = ushort.Parse(sptStrings[i], System.Globalization.NumberStyles.HexNumber);

                            bw.Write(myTempR16);
                            Type = 1;
                        }
                        else if (sptStrings[i].Length == 2)
                        {
                            byte myTempR8 = byte.Parse(sptStrings[i], System.Globalization.NumberStyles.HexNumber);

                            bw.Write(myTempR8);
                            Type = 2;
                        }

                    }






                    sbOffset.Append("#define    " + DefPrefix + item.SubItems[1].Text.Split('.')[0] + "    (0x" + index.ToString("X") + ")\n");
                    sbOffset.Append("\r\n\r\n");

                    if (Type == 0)
                    {
                        index += sptStrings.Length * 4;
                    }
                    else if (Type == 1)
                    {
                        index += sptStrings.Length * 2;
                    }
                    else
                    {
                        index += sptStrings.Length * 1;
                    }
                    sr.Close();
                    fsOpen.Close();
                }

                
            }
            bw.Flush();
            bw.Close();
            fsWrite.Close();

            sbOffset.Append("#define    RESOURCE_TOTAL_SIZE" + "    (0x" + index.ToString("X") + ")\n");
            sbOffset.Append("\r\n\r\n");

            sbOffset.Append("#endif\n");
            sbOffset.Append("\r\n\r\n");


            StreamWriter swForOffset = new StreamWriter(this.FolderPath + "/" + this.FileOffsetName, false, Encoding.GetEncoding("gb2312"));

            swForOffset.Write(sbOffset.ToString());
            swForOffset.Flush();
            swForOffset.Close();
            return true;
        }


    }
}
