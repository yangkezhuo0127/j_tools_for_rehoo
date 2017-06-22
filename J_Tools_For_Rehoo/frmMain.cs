using dbAccess;
using J_Tools_For_Rehoo.DataAccess;
using J_Tools_For_Rehoo.J_Forms;
using J_Tools_For_Rehoo.J_Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace J_Tools_For_Rehoo
{
    public partial class frmMain : Form
    {


        private J_RehooData j_rData;

        Action<string,DataTable> jsave;
        //Action jServer;
        Action jCreate;
 
        private FontManager opFont;
        private PicManager opPic;




        //private DataTable dt=new DataTable("dt");

        public frmMain()
        {
            InitializeComponent();

            j_rData = new J_RehooData();
            opFont = new FontManager(6, Application.StartupPath + @"\Output", "fontChars.h", "font.c");
            opPic = new PicManager(Application.StartupPath + @"\Output\PIC", "App_Resource_Offset.h");

 

            this.jsave += this.SaveToServer;
            //this.jServer += this.GetServerData;

            this.jCreate += this.CreateFiles;

 

        }

        private void tlAddFiles_Click(object sender, EventArgs e)
        {
            this.openFileDlg.Multiselect = true;
            this.openFileDlg.Title = "打开图片资源(bmp|png)";
            this.openFileDlg.Filter = "img files(*.bmp;*.png)|*.bmp;*.png|font file(*.sif)|*.sif";
            this.openFileDlg.FilterIndex = 1;
            this.openFileDlg.RestoreDirectory = true;
            this.openFileDlg.FileName = "";
            if (this.openFileDlg.ShowDialog() == DialogResult.OK)
            {

                string filename, filefullname;
                for (int i = 0; i < this.openFileDlg.FileNames.Count(); i++)
                {
                    ListViewItem lvItem = new ListViewItem((this.lvPics.Items.Count+1).ToString());
                    lvItem.Tag = Guid.NewGuid();
                    filefullname = this.openFileDlg.FileNames[i];
                    filename = this.openFileDlg.SafeFileNames[i];
                    lvItem.SubItems.Add(filename);
                    lvItem.SubItems.Add(filefullname);
                    this.lvPics.Items.Add(lvItem);
                    //DataRow r = dt.NewRow();
                    //r["guid"] = lvItem.Tag;
                    //r["fileName"] = filename;
                    //r["filePath"] = filefullname;
                    //dt.Rows.Add(r);
                                     
                    
                }
            }
        }

        private void tlSave_Click(object sender, EventArgs e)
        {

            //SetCtrlState(false);
            //dt.Rows.Clear();
            //foreach (ListViewItem item in this.lvPics.Items)
            //{
            //    DataRow r = dt.NewRow();
            //    r["guid"] = item.Tag;
            //    r["fileName"] = item.SubItems[1].Text;
            //    r["filePath"] = item.SubItems[2].Text;
            //    dt.Rows.Add(r);
            //}
            //IAsyncResult ar = jsave.BeginInvoke(this.txtFont.Text,this.dt, r =>
            //{
            //    this.BeginInvoke(new Action(() => {
            //        SetCtrlState(true);
            //    }));
                
            //    MessageBox.Show("保存成功！");
            //}, null);

        }


        //保存数据到服务器
        private void SaveToServer(string fontContent,DataTable dt)
        {

            StreamWriter sw = new StreamWriter(Application.StartupPath + @"\Data\Font.txt");
            sw.Write(fontContent);
            sw.Close();
            j_rData.EditFont(fontContent);

            j_rData.DropTable("Pic");
            foreach (DataRow row in dt.Rows)
            {
                j_rData.SavePicToServer(row["fileName"].ToString(), row["filePath"].ToString(),(Guid)row["guid"]);
            }
  
        }
        
        //从服务器获取数据
        private void GetServerData()
        {     
            //this.BeginInvoke(new Action(() =>
            //{
            //    try
            //    {
            //        this.txtFont.Text = j_rData.ReadFontContent();
            //        dt = j_rData.ReadPics();
            //        foreach (DataRow row in dt.Rows)
            //        {
            //            ListViewItem lvItem = new ListViewItem((this.lvPics.Items.Count + 1).ToString());
            //            lvItem.Tag = row["guid"];
            //            lvItem.SubItems.Add(row["fileName"].ToString());
            //            lvItem.SubItems.Add(row["filePath"].ToString());
            //            this.lvPics.Items.Add(lvItem);
            //        }
            //    }
            //    catch
            //    {

            //    }
            //}));
        }

        private void CreateFiles()
        {
            this.BeginInvoke(new Action(() =>
            {
                this.opFont.CreateFiles(Application.StartupPath + @"\Data\Font.txt");

                this.opPic.BinFileName = "Resource_Data.bin";

                foreach (ListViewItem item in this.lvPics.Items)
                {
                    string str = item.SubItems[2].Text + " -saveas" + Application.StartupPath + @"\Output\PIC\" + item.SubItems[1].Text.Split('.')[0] + ".h,"+"1 -exit";

                    Process.Start(Application.StartupPath + @"\BmpCvt.exe ", item.SubItems[2].Text + " -saveas" + Application.StartupPath + @"\Output\PIC\" + item.SubItems[1].Text.Split('.')[0] + ".h,1 -exit");

                        
    
                    Thread.Sleep(500);
                }


                if (this.lvPics.Items.Count > 0)
                {
                    Thread.Sleep(1000);
                    this.opPic.DefPrefix = "RESOURCE_OFFSET_ac";
                    this.opPic.CreateFile(this.lvPics);
                }
            }));
        }
        private void frmMain_Load(object sender, EventArgs e)
        {

            //Process p = new Process();  // 初始化新的进程
            //p.StartInfo.FileName = "CMD.EXE"; //创建CMD.EXE 进程
            //p.StartInfo.RedirectStandardInput = true; //重定向输入
            //p.StartInfo.RedirectStandardOutput = true;//重定向输出
            //p.StartInfo.UseShellExecute = false; // 不调用系统的Shell
            //p.StartInfo.RedirectStandardError = true; // 重定向Error
            //p.StartInfo.CreateNoWindow = true; //不创建窗口
            //p.Start(); // 启动进程
            //string str = "BmpCvt " + @"c:\1.png" + " -saveas" + Application.StartupPath + @"\Output\PIC\1.h,1 -exit";
            //p.StandardInput.WriteLine(str); // Cmd 命令
            //p.StandardInput.WriteLine("exit"); // 退出



            this.tlDel.Enabled = false;
            this.tlMoveDown.Enabled = false;
            this.tlMoveUp.Enabled = false;

            //IAsyncResult ar = jServer.BeginInvoke(r =>
            //{
            //    MessageBox.Show("加载成功！");
            //}, null);
         
        }

        private void tlCreate_Click(object sender, EventArgs e)
        {


            IAsyncResult ar = jCreate.BeginInvoke(r =>
            {

            }, null);   

        }

        private void tlDelAll_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == MessageBox.Show("您确定要全部删除吗?","提示", MessageBoxButtons.OKCancel,MessageBoxIcon.Question))
            {
                this.lvPics.Items.Clear();
                //this.dt.Rows.Clear();
            }
        }


        private void SetCtrlState(Boolean state)
        {
            this.tlAddFiles.Enabled = state;
            this.tlDelAll.Enabled = state;
            this.tlSave.Enabled = state;
            this.tlCreate.Enabled = state;
        }

        private void lvPics_DoubleClick(object sender, EventArgs e)
        {
            if (File.Exists(this.lvPics.SelectedItems[0].SubItems[2].Text))
            {
                Process.Start(this.lvPics.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                MessageBox.Show("该文件不存在！");
            }
        }

        private void tlDel_Click(object sender, EventArgs e)
        {
            if (this.lvPics.SelectedItems.Count>0)
            {
                foreach (ListViewItem item in this.lvPics.SelectedItems)
                {
                    //DataRow row = this.dt.Rows.Cast<DataRow>().Where(r =>
                    //{
                    //    return r["guid"] == item.Tag;
                    //}).First();

                    //this.dt.Rows.Remove(row);


                    for (int i = item.Index+1; i < this.lvPics.Items.Count; i++)
                    {
                        int id=Convert.ToInt32(this.lvPics.Items[i].SubItems[0].Text);
                        this.lvPics.Items[i].SubItems[0].Text = (--id).ToString();
                    }
                    this.lvPics.Items.Remove(item);
                }
            }

            this.tlDel.Enabled = false;
        }

        private void lvPics_MouseClick(object sender, MouseEventArgs e)
        {
            

            
        }

        private void tlGrpSetting_Click(object sender, EventArgs e)
        {
            frmGrpSetting grpSetting = new frmGrpSetting();

            grpSetting.ShowDialog();
        }

        private void lvPics_Click(object sender, EventArgs e)
        {
            string str=this.lvPics.SelectedItems[0].SubItems[1].Text;
            this.txtFileName.Text = str.Substring(0, str.LastIndexOf('.'));
            this.picShow.ImageLocation = this.lvPics.SelectedItems[0].SubItems[2].Text;
            //this.picShow.Image = Image.FromFile();
        }

        private void lvPics_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        //上移
        private void tlMoveUp_Click(object sender, EventArgs e)
        {
            if (this.lvPics.SelectedItems.Count == 0)
            {
                return;
            }
            this.lvPics.BeginUpdate();
            if (this.lvPics.SelectedItems[0].Index > 0)
            {
                foreach (ListViewItem lvi in this.lvPics.SelectedItems)
                {
                    ListViewItem lviSelectedItem = lvi;
                    int indexSelectedItem = lvi.Index;
                    this.lvPics.Items.RemoveAt(indexSelectedItem);
                    this.lvPics.Items.Insert(indexSelectedItem - 1, lviSelectedItem);
                }

     
            }
            this.lvPics.EndUpdate();
            if (this.lvPics.Items.Count > 0 && this.lvPics.SelectedItems.Count > 0)
            {
                this.lvPics.Focus();
                this.lvPics.SelectedItems[0].Focused = true;
                this.lvPics.SelectedItems[0].EnsureVisible();
            }
        }
        //下移
        private void tlMoveDown_Click(object sender, EventArgs e)
        {
            if (this.lvPics.SelectedItems.Count == 0)
            {
                return;
            }
            this.lvPics.BeginUpdate();
            int indexMaxSelectedItem = this.lvPics.SelectedItems[this.lvPics.SelectedItems.Count - 1].Index;
            if (indexMaxSelectedItem < this.lvPics.Items.Count - 1)
            {
                for (int i = this.lvPics.SelectedItems.Count - 1; i >= 0; i--)
                {
                    ListViewItem lviSelectedItem = this.lvPics.SelectedItems[i];
                    int indexSelectedItem = lviSelectedItem.Index;
                    this.lvPics.Items.RemoveAt(indexSelectedItem);
                    this.lvPics.Items.Insert(indexSelectedItem + 1, lviSelectedItem);
                }
            }
            this.lvPics.EndUpdate();
            if (this.lvPics.Items.Count > 0 && this.lvPics.SelectedItems.Count > 0)
            {
                this.lvPics.Focus();
                this.lvPics.SelectedItems[this.lvPics.SelectedItems.Count - 1].Focused = true;
                this.lvPics.SelectedItems[this.lvPics.SelectedItems.Count - 1].EnsureVisible();
            }
        }

   

        private void lvPics_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

 
            //ListViewItem item = this.lvPics.GetItemAt(e.X, e.Y);

            if (!e.IsSelected)
            {
                this.tlDel.Enabled = false;
                this.tlMoveDown.Enabled = false;
                this.tlMoveUp.Enabled = false;
            }
            else
            {
                this.tlDel.Enabled = true;
                this.tlMoveDown.Enabled = true;
                this.tlMoveUp.Enabled = true;
            }
        }

        private void tlRefresh_Click(object sender, EventArgs e)
        {
            this.tlDel.Enabled = false;
            this.tlMoveDown.Enabled = false;
            this.tlMoveUp.Enabled = false;
            this.lvPics.Items.Clear();
            //IAsyncResult ar = jServer.BeginInvoke(r =>
            //{
            //    MessageBox.Show("加载成功！");
            //}, null);
        }

        private void txtFileName_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) {

                if (this.txtFileName.Text.IndexOf('.')!=-1 || this.txtFileName.Text.IndexOf('-')!=-1 ||
                    this.txtFileName.Text.IndexOf('/')!=-1 || this.txtFileName.Text.IndexOf('\\')!=-1)
                {
                    MessageBox.Show("文件名不合法!");
                    return;
                }
              
                if (this.lvPics.SelectedItems.Count > 0)
                {
                    string str=this.lvPics.SelectedItems[0].SubItems[1].Text;
                    this.lvPics.SelectedItems[0].SubItems[1].Text = this.txtFileName.Text+str.Substring(str.LastIndexOf('.'),str.Length-str.LastIndexOf('.'));
                    if (this.cboxEdit.Checked)
                    {
                        string srcName=this.lvPics.SelectedItems[0].SubItems[2].Text;
                        int spt1 = srcName.LastIndexOf('\\');
                        string desName=srcName.Substring(0, spt1+1) + this.lvPics.SelectedItems[0].SubItems[1].Text;
                        this.lvPics.SelectedItems[0].SubItems[2].Text = desName;
 
                        File.Move(srcName, desName);
                        
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.txtFileName.Text.IndexOf('.') != -1 || this.txtFileName.Text.IndexOf('-') != -1 ||
                    this.txtFileName.Text.IndexOf('/') != -1 || this.txtFileName.Text.IndexOf('\\') != -1)
            {
                MessageBox.Show("文件名不合法!");
                return;
            }

            if (this.lvPics.SelectedItems.Count > 0)
            {
                string str = this.lvPics.SelectedItems[0].SubItems[1].Text;
                this.lvPics.SelectedItems[0].SubItems[1].Text = this.txtFileName.Text + str.Substring(str.LastIndexOf('.'), str.Length - str.LastIndexOf('.'));
                if (this.cboxEdit.Checked)
                {
                    string srcName = this.lvPics.SelectedItems[0].SubItems[2].Text;
                    int spt1 = srcName.LastIndexOf('\\');
                    string desName = srcName.Substring(0, spt1 + 1) + this.lvPics.SelectedItems[0].SubItems[1].Text;
                    this.lvPics.SelectedItems[0].SubItems[2].Text = desName;

                    File.Move(srcName, desName);

                }
            }
            
        }

        private void tlOpenPath_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath+@"\OutPut");
        }








    }
}
