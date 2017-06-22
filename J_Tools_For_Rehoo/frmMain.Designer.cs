namespace J_Tools_For_Rehoo
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tlSave = new System.Windows.Forms.ToolStripButton();
            this.tlCreate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tlOpenPath = new System.Windows.Forms.ToolStripButton();
            this.txtFont = new System.Windows.Forms.RichTextBox();
            this.sptCtrMain = new System.Windows.Forms.SplitContainer();
            this.sptCtrPic = new System.Windows.Forms.SplitContainer();
            this.lvPics = new System.Windows.Forms.ListView();
            this.col_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_picName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_picPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cboxEdit = new System.Windows.Forms.CheckBox();
            this.picShow = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tlAddFiles = new System.Windows.Forms.ToolStripButton();
            this.tlDelAll = new System.Windows.Forms.ToolStripButton();
            this.tlDel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlMoveUp = new System.Windows.Forms.ToolStripButton();
            this.tlMoveDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tlGrpSetting = new System.Windows.Forms.ToolStripButton();
            this.tlRefresh = new System.Windows.Forms.ToolStripButton();
            this.openFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.imgLst = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCtrMain)).BeginInit();
            this.sptCtrMain.Panel1.SuspendLayout();
            this.sptCtrMain.Panel2.SuspendLayout();
            this.sptCtrMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCtrPic)).BeginInit();
            this.sptCtrPic.Panel1.SuspendLayout();
            this.sptCtrPic.Panel2.SuspendLayout();
            this.sptCtrPic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).BeginInit();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlSave,
            this.tlCreate,
            this.toolStripSeparator1,
            this.tlOpenPath});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1014, 71);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tlSave
            // 
            this.tlSave.Image = ((System.Drawing.Image)(resources.GetObject("tlSave.Image")));
            this.tlSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlSave.Name = "tlSave";
            this.tlSave.Size = new System.Drawing.Size(100, 68);
            this.tlSave.Text = "保存";
            this.tlSave.Click += new System.EventHandler(this.tlSave_Click);
            // 
            // tlCreate
            // 
            this.tlCreate.Image = ((System.Drawing.Image)(resources.GetObject("tlCreate.Image")));
            this.tlCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlCreate.Name = "tlCreate";
            this.tlCreate.Size = new System.Drawing.Size(100, 68);
            this.tlCreate.Text = "生成";
            this.tlCreate.Click += new System.EventHandler(this.tlCreate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 71);
            // 
            // tlOpenPath
            // 
            this.tlOpenPath.Image = ((System.Drawing.Image)(resources.GetObject("tlOpenPath.Image")));
            this.tlOpenPath.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlOpenPath.Name = "tlOpenPath";
            this.tlOpenPath.Size = new System.Drawing.Size(148, 68);
            this.tlOpenPath.Text = "打开文件路径";
            this.tlOpenPath.Click += new System.EventHandler(this.tlOpenPath_Click);
            // 
            // txtFont
            // 
            this.txtFont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFont.Location = new System.Drawing.Point(0, 0);
            this.txtFont.Name = "txtFont";
            this.txtFont.Size = new System.Drawing.Size(283, 413);
            this.txtFont.TabIndex = 0;
            this.txtFont.Text = "";
            // 
            // sptCtrMain
            // 
            this.sptCtrMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sptCtrMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptCtrMain.Location = new System.Drawing.Point(0, 71);
            this.sptCtrMain.Name = "sptCtrMain";
            // 
            // sptCtrMain.Panel1
            // 
            this.sptCtrMain.Panel1.Controls.Add(this.txtFont);
            // 
            // sptCtrMain.Panel2
            // 
            this.sptCtrMain.Panel2.Controls.Add(this.sptCtrPic);
            this.sptCtrMain.Panel2.Controls.Add(this.toolStrip2);
            this.sptCtrMain.Size = new System.Drawing.Size(1014, 417);
            this.sptCtrMain.SplitterDistance = 287;
            this.sptCtrMain.TabIndex = 1;
            // 
            // sptCtrPic
            // 
            this.sptCtrPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sptCtrPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sptCtrPic.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sptCtrPic.Location = new System.Drawing.Point(0, 71);
            this.sptCtrPic.Name = "sptCtrPic";
            this.sptCtrPic.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sptCtrPic.Panel1
            // 
            this.sptCtrPic.Panel1.Controls.Add(this.lvPics);
            // 
            // sptCtrPic.Panel2
            // 
            this.sptCtrPic.Panel2.Controls.Add(this.cboxEdit);
            this.sptCtrPic.Panel2.Controls.Add(this.picShow);
            this.sptCtrPic.Panel2.Controls.Add(this.btnEdit);
            this.sptCtrPic.Panel2.Controls.Add(this.txtFileName);
            this.sptCtrPic.Panel2.Controls.Add(this.label1);
            this.sptCtrPic.Size = new System.Drawing.Size(723, 346);
            this.sptCtrPic.SplitterDistance = 60;
            this.sptCtrPic.TabIndex = 6;
            // 
            // lvPics
            // 
            this.lvPics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_id,
            this.col_picName,
            this.col_picPath});
            this.lvPics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPics.FullRowSelect = true;
            this.lvPics.HideSelection = false;
            this.lvPics.Location = new System.Drawing.Point(0, 0);
            this.lvPics.Name = "lvPics";
            this.lvPics.Size = new System.Drawing.Size(719, 56);
            this.lvPics.TabIndex = 4;
            this.lvPics.UseCompatibleStateImageBehavior = false;
            this.lvPics.View = System.Windows.Forms.View.Details;
            this.lvPics.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvPics_ItemSelectionChanged);
            this.lvPics.Click += new System.EventHandler(this.lvPics_Click);
            this.lvPics.DoubleClick += new System.EventHandler(this.lvPics_DoubleClick);
            // 
            // col_id
            // 
            this.col_id.Text = "id";
            this.col_id.Width = 99;
            // 
            // col_picName
            // 
            this.col_picName.Text = "图片名称";
            this.col_picName.Width = 229;
            // 
            // col_picPath
            // 
            this.col_picPath.Text = "图片路径";
            this.col_picPath.Width = 278;
            // 
            // cboxEdit
            // 
            this.cboxEdit.AutoSize = true;
            this.cboxEdit.Location = new System.Drawing.Point(80, 49);
            this.cboxEdit.Name = "cboxEdit";
            this.cboxEdit.Size = new System.Drawing.Size(108, 16);
            this.cboxEdit.TabIndex = 4;
            this.cboxEdit.Text = "同时修改文件名";
            this.cboxEdit.UseVisualStyleBackColor = true;
            // 
            // picShow
            // 
            this.picShow.Location = new System.Drawing.Point(441, 62);
            this.picShow.Name = "picShow";
            this.picShow.Size = new System.Drawing.Size(143, 167);
            this.picShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picShow.TabIndex = 3;
            this.picShow.TabStop = false;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(303, 18);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(45, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "修改";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(80, 21);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(216, 21);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtFileName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "文件名：";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(64, 64);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlAddFiles,
            this.tlDelAll,
            this.tlDel,
            this.toolStripSeparator2,
            this.tlMoveUp,
            this.tlMoveDown,
            this.toolStripSeparator3,
            this.tlGrpSetting,
            this.tlRefresh});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(723, 71);
            this.toolStrip2.TabIndex = 5;
            this.toolStrip2.Text = "toolStrip1";
            // 
            // tlAddFiles
            // 
            this.tlAddFiles.Image = ((System.Drawing.Image)(resources.GetObject("tlAddFiles.Image")));
            this.tlAddFiles.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlAddFiles.Name = "tlAddFiles";
            this.tlAddFiles.Size = new System.Drawing.Size(124, 68);
            this.tlAddFiles.Text = "添加文件";
            this.tlAddFiles.Click += new System.EventHandler(this.tlAddFiles_Click);
            // 
            // tlDelAll
            // 
            this.tlDelAll.Image = ((System.Drawing.Image)(resources.GetObject("tlDelAll.Image")));
            this.tlDelAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlDelAll.Name = "tlDelAll";
            this.tlDelAll.Size = new System.Drawing.Size(124, 68);
            this.tlDelAll.Text = "删除全部";
            this.tlDelAll.Click += new System.EventHandler(this.tlDelAll_Click);
            // 
            // tlDel
            // 
            this.tlDel.Image = ((System.Drawing.Image)(resources.GetObject("tlDel.Image")));
            this.tlDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlDel.Name = "tlDel";
            this.tlDel.Size = new System.Drawing.Size(100, 68);
            this.tlDel.Text = "删除";
            this.tlDel.Click += new System.EventHandler(this.tlDel_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 71);
            // 
            // tlMoveUp
            // 
            this.tlMoveUp.Image = ((System.Drawing.Image)(resources.GetObject("tlMoveUp.Image")));
            this.tlMoveUp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlMoveUp.Name = "tlMoveUp";
            this.tlMoveUp.Size = new System.Drawing.Size(100, 68);
            this.tlMoveUp.Text = "上移";
            this.tlMoveUp.Click += new System.EventHandler(this.tlMoveUp_Click);
            // 
            // tlMoveDown
            // 
            this.tlMoveDown.Image = ((System.Drawing.Image)(resources.GetObject("tlMoveDown.Image")));
            this.tlMoveDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlMoveDown.Name = "tlMoveDown";
            this.tlMoveDown.Size = new System.Drawing.Size(100, 68);
            this.tlMoveDown.Text = "下移";
            this.tlMoveDown.Click += new System.EventHandler(this.tlMoveDown_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 71);
            // 
            // tlGrpSetting
            // 
            this.tlGrpSetting.Image = ((System.Drawing.Image)(resources.GetObject("tlGrpSetting.Image")));
            this.tlGrpSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlGrpSetting.Name = "tlGrpSetting";
            this.tlGrpSetting.Size = new System.Drawing.Size(124, 68);
            this.tlGrpSetting.Text = "分组设置";
            this.tlGrpSetting.Click += new System.EventHandler(this.tlGrpSetting_Click);
            // 
            // tlRefresh
            // 
            this.tlRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tlRefresh.Image")));
            this.tlRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tlRefresh.Name = "tlRefresh";
            this.tlRefresh.Size = new System.Drawing.Size(100, 68);
            this.tlRefresh.Text = "刷新";
            this.tlRefresh.Click += new System.EventHandler(this.tlRefresh_Click);
            // 
            // openFileDlg
            // 
            this.openFileDlg.FileName = "openFileDialog1";
            // 
            // imgLst
            // 
            this.imgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLst.ImageStream")));
            this.imgLst.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLst.Images.SetKeyName(0, "addFiles");
            this.imgLst.Images.SetKeyName(1, "save");
            this.imgLst.Images.SetKeyName(2, "create");
            this.imgLst.Images.SetKeyName(3, "refresh");
            this.imgLst.Images.SetKeyName(4, "del");
            this.imgLst.Images.SetKeyName(5, "moveUp");
            this.imgLst.Images.SetKeyName(6, "moveDown");
            this.imgLst.Images.SetKeyName(7, "delAll");
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 488);
            this.Controls.Add(this.sptCtrMain);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "Rehoo公司文字图片生成工具";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.sptCtrMain.Panel1.ResumeLayout(false);
            this.sptCtrMain.Panel2.ResumeLayout(false);
            this.sptCtrMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCtrMain)).EndInit();
            this.sptCtrMain.ResumeLayout(false);
            this.sptCtrPic.Panel1.ResumeLayout(false);
            this.sptCtrPic.Panel2.ResumeLayout(false);
            this.sptCtrPic.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sptCtrPic)).EndInit();
            this.sptCtrPic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picShow)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox txtFont;
        private System.Windows.Forms.SplitContainer sptCtrMain;
        private System.Windows.Forms.OpenFileDialog openFileDlg;
        private System.Windows.Forms.ToolStripButton tlSave;
        private System.Windows.Forms.ToolStripButton tlCreate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ImageList imgLst;
        private System.Windows.Forms.SplitContainer sptCtrPic;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tlAddFiles;
        private System.Windows.Forms.ToolStripButton tlDelAll;
        private System.Windows.Forms.ToolStripButton tlDel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlMoveUp;
        private System.Windows.Forms.ToolStripButton tlMoveDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlGrpSetting;
        private System.Windows.Forms.ToolStripButton tlRefresh;
        private System.Windows.Forms.ListView lvPics;
        private System.Windows.Forms.ColumnHeader col_id;
        private System.Windows.Forms.ColumnHeader col_picName;
        private System.Windows.Forms.ColumnHeader col_picPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox picShow;
        private System.Windows.Forms.CheckBox cboxEdit;
        private System.Windows.Forms.ToolStripButton tlOpenPath;


    }
}

