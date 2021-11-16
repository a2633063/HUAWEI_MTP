namespace MTP
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.comboDevices = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.log = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonDevices = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.Label();
            this.reFile = new System.Windows.Forms.Button();
            this.CopyToPath = new System.Windows.Forms.Button();
            this.CopyToDesktop = new System.Windows.Forms.Button();
            this.RefileSD = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletefile = new System.Windows.Forms.Button();
            this.screenshot = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.getTxt = new System.Windows.Forms.Button();
            this.filedelete = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.chkAPKCopy = new System.Windows.Forms.CheckBox();
            this.btnSaveTxt = new System.Windows.Forms.Button();
            this.typeenable = new System.Windows.Forms.CheckBox();
            this.devicechose = new System.Windows.Forms.CheckBox();
            this.showhidefile = new System.Windows.Forms.CheckBox();
            this.adbPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panelQuickPathList = new System.Windows.Forms.Panel();
            this.MenuQuickPath = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.MenuQuickPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.AllowDrop = true;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(8, 127);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(300, 640);
            this.listBox1.TabIndex = 1;
            this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
            this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
            this.listBox1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "执行自定义命令";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(12, 16);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 4;
            this.label20.Text = "adb路径:";
            // 
            // comboDevices
            // 
            this.comboDevices.FormattingEnabled = true;
            this.comboDevices.Location = new System.Drawing.Point(71, 40);
            this.comboDevices.Name = "comboDevices";
            this.comboDevices.Size = new System.Drawing.Size(237, 20);
            this.comboDevices.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "当前设备:";
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(312, 500);
            this.log.Multiline = true;
            this.log.Name = "log";
            this.log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.log.Size = new System.Drawing.Size(372, 267);
            this.log.TabIndex = 7;
            this.log.DoubleClick += new System.EventHandler(this.log_DoubleClick);
            this.log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.log_KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 21);
            this.textBox2.TabIndex = 8;
            // 
            // buttonDevices
            // 
            this.buttonDevices.Location = new System.Drawing.Point(316, 40);
            this.buttonDevices.Name = "buttonDevices";
            this.buttonDevices.Size = new System.Drawing.Size(88, 20);
            this.buttonDevices.TabIndex = 9;
            this.buttonDevices.Text = "刷新设备";
            this.buttonDevices.UseVisualStyleBackColor = true;
            this.buttonDevices.Click += new System.EventHandler(this.buttonDevices_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "自定义参数";
            // 
            // Path
            // 
            this.Path.AutoSize = true;
            this.Path.Location = new System.Drawing.Point(6, 770);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(101, 12);
            this.Path.TabIndex = 11;
            this.Path.Text = "storage/emulated/0";
            this.Path.DoubleClick += new System.EventHandler(this.Path_DoubleClick);
            // 
            // reFile
            // 
            this.reFile.Location = new System.Drawing.Point(8, 97);
            this.reFile.Name = "reFile";
            this.reFile.Size = new System.Drawing.Size(198, 23);
            this.reFile.TabIndex = 13;
            this.reFile.Text = "刷新列表";
            this.reFile.UseVisualStyleBackColor = true;
            this.reFile.Click += new System.EventHandler(this.reFile_Click);
            // 
            // CopyToPath
            // 
            this.CopyToPath.Location = new System.Drawing.Point(6, 47);
            this.CopyToPath.Name = "CopyToPath";
            this.CopyToPath.Size = new System.Drawing.Size(90, 23);
            this.CopyToPath.TabIndex = 16;
            this.CopyToPath.Text = "复制到此路径";
            this.CopyToPath.UseVisualStyleBackColor = true;
            this.CopyToPath.Click += new System.EventHandler(this.CopyToPath_Click);
            // 
            // CopyToDesktop
            // 
            this.CopyToDesktop.Location = new System.Drawing.Point(6, 76);
            this.CopyToDesktop.Name = "CopyToDesktop";
            this.CopyToDesktop.Size = new System.Drawing.Size(90, 23);
            this.CopyToDesktop.TabIndex = 17;
            this.CopyToDesktop.Text = "复制到桌面";
            this.CopyToDesktop.UseVisualStyleBackColor = true;
            this.CopyToDesktop.Click += new System.EventHandler(this.CopyToDesktop_Click);
            // 
            // RefileSD
            // 
            this.RefileSD.Location = new System.Drawing.Point(212, 97);
            this.RefileSD.Name = "RefileSD";
            this.RefileSD.Size = new System.Drawing.Size(96, 23);
            this.RefileSD.TabIndex = 13;
            this.RefileSD.Text = "默认目录";
            this.RefileSD.UseVisualStyleBackColor = true;
            this.RefileSD.Click += new System.EventHandler(this.RefileSD_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletefile);
            this.groupBox1.Controls.Add(this.screenshot);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.CopyToPath);
            this.groupBox1.Controls.Add(this.CopyToDesktop);
            this.groupBox1.Location = new System.Drawing.Point(312, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 102);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // deletefile
            // 
            this.deletefile.Location = new System.Drawing.Point(272, 76);
            this.deletefile.Name = "deletefile";
            this.deletefile.Size = new System.Drawing.Size(90, 23);
            this.deletefile.TabIndex = 19;
            this.deletefile.Text = "删除文件";
            this.deletefile.UseVisualStyleBackColor = true;
            this.deletefile.Click += new System.EventHandler(this.deletefile_Click);
            // 
            // screenshot
            // 
            this.screenshot.Location = new System.Drawing.Point(102, 47);
            this.screenshot.Name = "screenshot";
            this.screenshot.Size = new System.Drawing.Size(90, 23);
            this.screenshot.TabIndex = 18;
            this.screenshot.Text = "截图";
            this.screenshot.UseVisualStyleBackColor = true;
            this.screenshot.Click += new System.EventHandler(this.screenshot_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MTP.Properties.Settings.Default, "computerPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(358, 21);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = global::MTP.Properties.Settings.Default.computerPath;
            this.textBox1.DoubleClick += new System.EventHandler(this.textBox1_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.getTxt);
            this.groupBox2.Location = new System.Drawing.Point(312, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 69);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // getTxt
            // 
            this.getTxt.Location = new System.Drawing.Point(29, 17);
            this.getTxt.Name = "getTxt";
            this.getTxt.Size = new System.Drawing.Size(325, 43);
            this.getTxt.TabIndex = 0;
            this.getTxt.Text = "获取文本";
            this.getTxt.UseVisualStyleBackColor = true;
            this.getTxt.Click += new System.EventHandler(this.getTxt_Click);
            // 
            // filedelete
            // 
            this.filedelete.AllowDrop = true;
            this.filedelete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.filedelete.Font = new System.Drawing.Font("华文楷体", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.filedelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.filedelete.Location = new System.Drawing.Point(312, 405);
            this.filedelete.Name = "filedelete";
            this.filedelete.Size = new System.Drawing.Size(372, 92);
            this.filedelete.TabIndex = 21;
            this.filedelete.Text = "拖动文件到此复制/安装";
            this.filedelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.filedelete.UseMnemonic = false;
            this.filedelete.DragDrop += new System.Windows.Forms.DragEventHandler(this.apkInstall_DragDrop);
            this.filedelete.DragEnter += new System.Windows.Forms.DragEventHandler(this.apkInstall_DragEnter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "adb.exe";
            this.openFileDialog1.Filter = "adb执行文件|adb.exe";
            this.openFileDialog1.Title = "选择adb文件";
            // 
            // chkAPKCopy
            // 
            this.chkAPKCopy.AutoSize = true;
            this.chkAPKCopy.Location = new System.Drawing.Point(543, 478);
            this.chkAPKCopy.Name = "chkAPKCopy";
            this.chkAPKCopy.Size = new System.Drawing.Size(138, 16);
            this.chkAPKCopy.TabIndex = 22;
            this.chkAPKCopy.Text = "拷贝apk文件而不安装";
            this.chkAPKCopy.UseVisualStyleBackColor = true;
            // 
            // btnSaveTxt
            // 
            this.btnSaveTxt.Location = new System.Drawing.Point(591, 743);
            this.btnSaveTxt.Name = "btnSaveTxt";
            this.btnSaveTxt.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTxt.TabIndex = 23;
            this.btnSaveTxt.Text = "写入文本";
            this.btnSaveTxt.UseVisualStyleBackColor = true;
            this.btnSaveTxt.Click += new System.EventHandler(this.btnSaveTxt_Click);
            // 
            // typeenable
            // 
            this.typeenable.AutoSize = true;
            this.typeenable.Checked = global::MTP.Properties.Settings.Default.typeenable;
            this.typeenable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.typeenable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MTP.Properties.Settings.Default, "typeenable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.typeenable.Location = new System.Drawing.Point(316, 109);
            this.typeenable.Name = "typeenable";
            this.typeenable.Size = new System.Drawing.Size(72, 16);
            this.typeenable.TabIndex = 12;
            this.typeenable.Text = "类型排序";
            this.typeenable.UseVisualStyleBackColor = true;
            // 
            // devicechose
            // 
            this.devicechose.AutoSize = true;
            this.devicechose.Checked = global::MTP.Properties.Settings.Default.devicechose;
            this.devicechose.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MTP.Properties.Settings.Default, "devicechose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.devicechose.Location = new System.Drawing.Point(410, 42);
            this.devicechose.Name = "devicechose";
            this.devicechose.Size = new System.Drawing.Size(72, 16);
            this.devicechose.TabIndex = 14;
            this.devicechose.Text = "选择设备";
            this.devicechose.UseVisualStyleBackColor = true;
            // 
            // showhidefile
            // 
            this.showhidefile.AutoSize = true;
            this.showhidefile.Checked = global::MTP.Properties.Settings.Default.showhidefile;
            this.showhidefile.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::MTP.Properties.Settings.Default, "showhidefile", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.showhidefile.Location = new System.Drawing.Point(316, 91);
            this.showhidefile.Name = "showhidefile";
            this.showhidefile.Size = new System.Drawing.Size(96, 16);
            this.showhidefile.TabIndex = 12;
            this.showhidefile.Text = "显示隐藏文件";
            this.showhidefile.UseVisualStyleBackColor = true;
            // 
            // adbPath
            // 
            this.adbPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::MTP.Properties.Settings.Default, "adbPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.adbPath.Location = new System.Drawing.Point(71, 13);
            this.adbPath.Name = "adbPath";
            this.adbPath.Size = new System.Drawing.Size(603, 21);
            this.adbPath.TabIndex = 2;
            this.adbPath.Text = global::MTP.Properties.Settings.Default.adbPath;
            this.adbPath.DoubleClick += new System.EventHandler(this.adbPath_DoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panelQuickPathList);
            this.groupBox3.Location = new System.Drawing.Point(312, 229);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(372, 107);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "快捷路径";
            // 
            // panelQuickPathList
            // 
            this.panelQuickPathList.ContextMenuStrip = this.MenuQuickPath;
            this.panelQuickPathList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQuickPathList.Location = new System.Drawing.Point(3, 17);
            this.panelQuickPathList.Name = "panelQuickPathList";
            this.panelQuickPathList.Size = new System.Drawing.Size(366, 87);
            this.panelQuickPathList.TabIndex = 22;
            this.toolTip1.SetToolTip(this.panelQuickPathList, "右击菜单配置快捷路径");
            // 
            // MenuQuickPath
            // 
            this.MenuQuickPath.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.新增ToolStripMenuItem});
            this.MenuQuickPath.Name = "MenuQucikPath";
            this.MenuQuickPath.Size = new System.Drawing.Size(181, 92);
            this.MenuQuickPath.Opening += new System.ComponentModel.CancelEventHandler(this.MenuQuickPath_Opening);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.设置ToolStripMenuItem.Text = "编辑";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.新增ToolStripMenuItem.Text = "新增";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(687, 783);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSaveTxt);
            this.Controls.Add(this.chkAPKCopy);
            this.Controls.Add(this.filedelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.typeenable);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.devicechose);
            this.Controls.Add(this.RefileSD);
            this.Controls.Add(this.reFile);
            this.Controls.Add(this.showhidefile);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDevices);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboDevices);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.adbPath);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "MTP";
            this.Deactivate += new System.EventHandler(this.setting_save);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.MenuQuickPath.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox adbPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ComboBox comboDevices;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox log;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonDevices;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Path;
        private System.Windows.Forms.CheckBox showhidefile;
        private System.Windows.Forms.Button reFile;
        private System.Windows.Forms.CheckBox devicechose;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button CopyToPath;
        private System.Windows.Forms.Button CopyToDesktop;
        private System.Windows.Forms.Button RefileSD;
        private System.Windows.Forms.CheckBox typeenable;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button getTxt;
        private System.Windows.Forms.Label filedelete;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button screenshot;
        private System.Windows.Forms.Button deletefile;
        private System.Windows.Forms.CheckBox chkAPKCopy;
        private System.Windows.Forms.Button btnSaveTxt;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panelQuickPathList;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip MenuQuickPath;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
    }
}

