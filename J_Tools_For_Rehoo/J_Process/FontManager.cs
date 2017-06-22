using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace J_Tools_For_Rehoo.J_Process
{
    public class FontManager
    {
        public FontManager(int LangCount, string FolderPath, string fileCharsName, string fileFontName)
        {
            this.LangCount = LangCount;
            this.FileCharsName = fileCharsName;
            this.FileFontName = fileFontName;
            this.FolderPath = FolderPath;
        }


        //要存储的文件夹
        public string FolderPath { get; set; }
        //fontChars.h
        public string FileCharsName { get; set; }
        //Font.h
        public string FileFontName { get; set; }
        //版本号
        public string Version { get; set; }
        //作者
        public string Author { get; set; }
        //标题fontChars
        public string TitleForChars { get; set; }
        //标题font
        public string TitleForFont { get; set; }

        //语言个数
        public int LangCount { get; set; }
        //const INT8U g_LangChars[]
        public string DefForChars { get; set; }

        public string DefForFont { get; set; }

        public bool CreateFiles(string srcFilePath)
        {
            bool rtValue = false;
            StringBuilder sbChars = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*" + this.TitleForChars + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: " + this.FileCharsName + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");
            StringBuilder sbFont = new StringBuilder(
                "/***********************************************************************************************************\n" +
                "*" + this.TitleForChars + "\n" +
                "*											                                                                 \n" +
                "*                                                                                                           \n" +
                "* 文件名	: " + this.FileFontName + "\n" +
                "* 版本号	: " + this.Version + "\n" +
                "* 作着		: " + this.Author + "\n" +
                "************************************************************************************************************\n" +
                "*/\n");

            sbChars.Append("#ifndef _" + this.FileCharsName.ToUpper().Split('.')[0] + "_H\n" +
                       "#define _" + this.FileCharsName.ToUpper().Split('.')[0] + "_H\n");

            sbFont.Append("#ifndef _" + this.FileFontName.ToUpper().Split('.')[0] + "_H\n" +
                       "#define _" + this.FileFontName.ToUpper().Split('.')[0] + "_H\n");

            sbChars.Append(this.DefForChars + "={\n\r");
            sbFont.Append(this.DefForFont + "={\n\r");

            FileStream fsOpenForChars = new FileStream(srcFilePath, FileMode.Open);
            StreamReader sr = new StreamReader(fsOpenForChars);


            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string strLine = "";
            long index = 0;
            long totalCount = 1;
            long itemIndex = 0;
            while (strLine != null)
            {
                strLine = sr.ReadLine();
                if (!string.IsNullOrWhiteSpace(strLine))
                {
                    byte[] utf8 = Encoding.UTF8.GetBytes(strLine);
                    sbChars.Append("   ");
                    sbChars.Append(string.Join(",", utf8));
                    sbChars.Append(",0,\n");

                    sbFont.Append("   ");

                    if (totalCount++ % this.LangCount == 0)
                    {
                        sbFont.Append(index.ToString() + ", // " + strLine + "      (id)=>(" + itemIndex++ + ")" + "\n");
                        sbFont.Append("\n\r");
                    }
                    else
                    {
                        sbFont.Append(index.ToString() + ", // " + strLine + "\n");
                    }
                    index += utf8.Length + 1;

                }

            }
            sr.Close();
            fsOpenForChars.Close();


            sbChars.Append("};\n");
            sbChars.Append("#endif\n");
            sbChars.Append("\r\n\r\n");


            sbFont.Append("};\n");
            sbFont.Append("#endif\n");

            sbFont.Append("\r\n\r\n");

            StreamWriter swForChars = new StreamWriter(this.FolderPath + "/" + this.FileCharsName);
            StreamWriter swForFont = new StreamWriter(this.FolderPath + "/" + this.FileFontName);
            swForChars.Write(sbChars.ToString());
            swForChars.Flush();
            swForChars.Close();

            swForFont.Write(sbFont.ToString());
            swForFont.Flush();
            swForFont.Close();

            return rtValue;
        }

    }
}
