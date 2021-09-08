using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP
{
    public partial class Form1 : Form
    {
        string SDcard_path;
        bool path_save_flag = false;

        List<Button> ListQuickPath = new List<Button>();
        public Form1()
        {
            InitializeComponent();
            #region 设置保存初始化
            string str = Properties.Settings.Default.Path1;
            string[] str_arr = str.Split('\n');//\n分割按钮  \r分割标题和路径
            foreach (string s in str_arr)
            {
                string[] str_path = s.Split('\r');
                if (str_path.Length != 2) continue;
                ListQuickPath.Add(newPathButton(str_path[0], str_path[1]));
            }

            if (ListQuickPath.Count < 1)
            {
                ListQuickPath.Add(newPathButton("默认路径", "storage/emulated/0"));
            }
            _ListQuickPath_Layout();
            #endregion
        }
        Button newPathButton(string _name, string _path)
        {
            Button l = new Button();
            l.Text = _name;
            l.Tag = _path;
            l.Click += QuickPath_Click;
            l.ContextMenuStrip = MenuQuickPath;
            toolTip1.SetToolTip(l, (string)l.Tag + "\r\n右键菜单设置");
            return l;
        }
        void _ListQuickPath_Layout()
        {
            const int QUICK_PATH_BUTTON_WIDTH = 73; //按钮宽度
            const int QUICK_PATH_BUTTON_HIGHT = 23;  //按钮高度
            const int QUICK_PATH_BUTTON_SPACE_X = 0; //按钮横向间距
            const int QUICK_PATH_BUTTON_SPACE_Y = 0; //按钮竖向间距
            const int QUICK_PATH_BUTTON_START_X = 0; //第一个按钮x坐标
            const int QUICK_PATH_BUTTON_START_Y = 6; //第一个按钮y坐标

            panelQuickPathList.Controls.Clear();
            for (int i = 0; i < ListQuickPath.Count; i++)
            {
                Point p = new Point();
                p.X = QUICK_PATH_BUTTON_START_X + i % 5 * (QUICK_PATH_BUTTON_WIDTH + QUICK_PATH_BUTTON_SPACE_X);
                p.Y = QUICK_PATH_BUTTON_START_Y + i / 5 * (QUICK_PATH_BUTTON_HIGHT + QUICK_PATH_BUTTON_SPACE_Y);

                ListQuickPath[i].Location = p;
                ListQuickPath[i].Width = QUICK_PATH_BUTTON_WIDTH;
                ListQuickPath[i].Height = QUICK_PATH_BUTTON_HIGHT;
                panelQuickPathList.Controls.Add(ListQuickPath[i]);
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = this.Text + " v" + System.Diagnostics.FileVersionInfo.GetVersionInfo(Application.ExecutablePath).FileVersion;

            buttonDevices_Click(null, null);

            if (comboDevices.Items.Count > 0)
                RefileSD_Click(null, null);

            if (textBox1.Text.Length < 2)
                textBox1.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);


        }

        private void setting_save(object sender, EventArgs e)
        {
            if(path_save_flag)
            {
                string str = "";
                path_save_flag = false;
                foreach(Button b in ListQuickPath)
                {//\n分割按钮  \r分割标题和路径
                    str += b.Text + "\r" + (string)b.Tag +"\n";
                }

                Properties.Settings.Default.Path1 = str;
            }
            Properties.Settings.Default.Save();
        }
        private void buttonDevices_Click(object sender, EventArgs e)
        {
            log.Text = "";
            String resultStr = adbCmd("devices");
            string[] result = resultStr.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); //忽略空行
            comboDevices.Items.Clear();
            if (result[0].StartsWith("error"))
            {
                log.Text = resultStr;
            }
            else
            {
                foreach (String s in result)
                {
                    if (s.Contains("	"))
                    {
                        comboDevices.Items.Add(s.Split('	')[0]);
                    }
                }

                if (comboDevices.Items.Count == 0)
                {
                    comboDevices.Text = "";
                }
                else if (comboDevices.Items.Contains(comboDevices.Text)) comboDevices.Text = comboDevices.Text;
                else if (comboDevices.Text.Length < 1) { comboDevices.SelectedIndex = 0; }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //ListFolderInfos();
            if (textBox2.Text.Length < 1) { log.Text = "参数为空"; return; }
            String reader = adbCmd(textBox2.Text);
            log.Text = reader;
        }

        private String adbCmd(String cmd)
        {
            // cmd =Encoding.UTF8.GetString(Encoding.Default.GetBytes(cmd));
            //cmd=Encoding.Convert(Encoding.GetEncoding("GBK"), Encoding.UTF8, cmd.);
            try
            {

                String deviceStr = "";
                if (devicechose.Checked && comboDevices.Text.Length > 1 && !cmd.Trim().Equals("devices"))
                {
                    deviceStr = "-s " + comboDevices.Text;
                }

                Process p = new Process();
                p.StartInfo.FileName = adbPath.Text;           //设定程序名   
                p.StartInfo.Arguments = deviceStr + " " + cmd;// folderpath; //ls命令  foldername:"storage/emulated/0"
                p.StartInfo.UseShellExecute = false;        //关闭Shell的使用   
                p.StartInfo.RedirectStandardInput = true;   //重定向标准输入   
                p.StartInfo.RedirectStandardOutput = true;  //重定向标准输出   
                p.StartInfo.RedirectStandardError = true;   //重定向错误输出   
                p.StartInfo.CreateNoWindow = true;          //设置不显示窗口   
                p.StartInfo.StandardOutputEncoding = Encoding.UTF8;
                p.Start();

                String result = p.StandardOutput.ReadToEnd();
                String error = p.StandardError.ReadToEnd();
                p.Close();

                log.AppendText("adb " + (deviceStr + " " + cmd).Trim() + "\r\n");
                if (result != "")
                    return result;
                else
                {
                    if (error == "") error = "error:无返回结果";
                    return error;
                }
            }
            catch (Exception e)
            {
                return "error: " + e.Message + ((e.Message.Contains("系统找不到指定的文件")) ? "\r\n请保证adb.exe路径正确" : "");
            }

        }
        private String adbList(String strPath)
        {
            if (!strPath.EndsWith("/")) strPath = strPath + "/";
            String strcmd = adbCmd("shell " + (showhidefile.Checked ? " ls -A -F " : "ls -F ") + strPath);
            if (strcmd.StartsWith("error:无返回结果"))
            {
                strcmd = "";
                //MessageBox.Show("文件夹为空");
                //return "";
            }
            else if (strcmd.Contains("ls:"))
            {
                MessageBox.Show(strcmd, "错误");
                return "";
            }
            Path.Text = strPath;
            string[] result = strcmd.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries); //忽略空行
            listBox1.Items.Clear();
            if (strPath.Length > 1 && !strPath.Equals("storage/emulated/0/"))
                listBox1.Items.Add("..");

            if (typeenable.Checked)
            {
                foreach (String s in result)
                {
                    if (s.EndsWith("/"))
                        listBox1.Items.Add(s);
                }
                foreach (String s in result)
                {
                    if (!s.EndsWith("/"))
                        listBox1.Items.Add(s);
                }
            }
            else
            {
                foreach (String s in result)
                {
                    listBox1.Items.Add(s);
                }
            }
            return "";
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox1.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)//!=-1
            {
                String strfile = listBox1.Items[index].ToString();
                if (strfile.Equals(".."))
                {
                    String str = Path.Text.Substring(0, Path.Text.Length - 1);
                    int temp = str.LastIndexOf('/');
                    if (temp > 0)
                        str = str.Substring(0, temp);
                    else str = "";
                    adbList(str);
                }
                else if (strfile.EndsWith("/") || strfile.EndsWith("@") || strfile.EndsWith("="))//"@"表示符号链接、"|"表示FIFOS、"/"表示目录、"="表示套接字。
                {
                    if (strfile.EndsWith("@")) strfile = strfile.Substring(0, strfile.Length - 1);
                    if (strfile.EndsWith("=")) strfile = strfile.Substring(0, strfile.Length - 1);
                    adbList(Path.Text + strfile);
                }
                else if (strfile.EndsWith(".txt") || strfile.EndsWith(".xml") || strfile.EndsWith(".ini")
                   || strfile.EndsWith(".png") || strfile.EndsWith(".jpg"))
                {
                    CopyToDesktop_Click(null, null);
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
                    //info.WorkingDirectory = Application.StartupPath;
                    info.FileName = desktopPath + "/" + strfile;
                    info.Arguments = "";
                    try
                    {
                        System.Diagnostics.Process.Start(info);
                    }
                    catch (System.ComponentModel.Win32Exception we)
                    {
                        MessageBox.Show(this, "失败:" + we.Message);
                        return;
                    }
                }
            }
        }

        private void reFile_Click(object sender, EventArgs e)
        {
            adbList(Path.Text);
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            if (path.SelectedPath.Length > 1)
            {
                textBox1.Text = path.SelectedPath;

            }
        }

        private void CopyToPath_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                string tar_path = textBox1.Text;
                if (!tar_path.EndsWith("/")) tar_path = tar_path + "/";
                log.AppendText(adbCmd("pull \"" + Path.Text + listBox1.SelectedItem.ToString() + "\" \"" + tar_path + listBox1.SelectedItem.ToString() + "\""));
            }
        }

        private void CopyToDesktop_Click(object sender, EventArgs e)
        {
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            if (listBox1.SelectedIndex > 0)
            {
                log.AppendText(adbCmd("pull \"" + Path.Text + listBox1.SelectedItem.ToString() + "\" \"" + desktopPath + "\\" + listBox1.SelectedItem.ToString() + "\""));
            }


        }



        private void log_DoubleClick(object sender, EventArgs e)
        {
            log.Text = "";
        }
        private void log_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                ((TextBox)sender).SelectAll();
            }
        }

        private void RefileSD_Click(object sender, EventArgs e)
        {
            //SDcard_path = adbCmd("shell echo $EXTERNAL_STORAGE").Trim().Replace("\r","").Replace("\n", "");
            //adbList(SDcard_path);
            adbList("storage/emulated/0");
        }

        private void Path_DoubleClick(object sender, EventArgs e)
        {
            String s = Path.Text + ((listBox1.SelectedIndex > 0) ? listBox1.SelectedItem.ToString() : "");
            Clipboard.SetText(s);
            log.Text = "路径已复制:" + s;
        }

        private void getTxt_Click(object sender, EventArgs e)
        {
            String reader = adbCmd("shell cat storage/emulated/0/_Zip/file/temp.txt");
            log.Text = reader;
            if (reader.Contains("temp.txt: No such file or directory"))
            {
                log.AppendText("获取失败,请保证temp.txt文件存在储存_Zip/file目录下.(可以用APP自动生成)" + "\r\n");
            }
        }



        private void apkInstall_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Link;
            else e.Effect = DragDropEffects.None;
        }

        private void apkInstall_DragDrop(object sender, DragEventArgs e)
        {
            bool isApk = false, isFile = false;
            if (comboDevices.Items.Count < 1)
            {
                buttonDevices_Click(null, null);
                return;
            }
            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in filePath)
            {
                //MessageBox.Show(file);
                if (file.EndsWith("apk") && !chkAPKCopy.Checked)
                {
                    isApk = true;
                    log.AppendText(adbCmd("install \"" + file + "\"") + "\r\n");
                }
                else
                {
                    isFile = true;
                    Regex reg = new Regex(@".*\\");
                    string fileName = reg.Replace(file, "");

                    log.AppendText(adbCmd("push \"" + file + "\" \"/storage/emulated/0/_Zip/file/" + fileName + "\"") + "\r\n");

                    //MessageBox.Show(file);
                }

            }

            if (isApk) log.AppendText("apk文件安装命令已执行\r\n");
            if (isFile) log.AppendText("文件复制至存储空间命令已执行 _Zip/file文件夹内\r\n");
        }

        private void adbPath_DoubleClick(object sender, EventArgs e)
        {
            OpenFileDialog adb = new OpenFileDialog();
            adb.FileName = "adb.exe";
            adb.Filter = "adb执行文件|adb.exe";
            adb.Title = "选择adb文件";
            adb.ShowDialog();
        }

        private void screenshot_Click(object sender, EventArgs e)
        {
            adbCmd("shell screencap -p \"" + Path.Text + "screenshot.png\"");
            reFile_Click(null, null);
            listBox1.SelectedItem = "screenshot.png";
        }

        private void deletefile_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1 && !listBox1.SelectedItem.ToString().Equals(".."))
            {
                DialogResult dr = MessageBox.Show("您将删除文件:" + Path.Text + listBox1.SelectedItem.ToString() + "\r\n执行命令:adb shell rm " + Path.Text + listBox1.SelectedItem.ToString() + "\r\n确认?", "注意", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.OK)
                {//确定
                    int x = listBox1.SelectedIndex;
                    adbCmd("shell rm \"" + Path.Text + listBox1.SelectedItem.ToString() + "\"");
                    reFile_Click(null, null);
                    listBox1.SelectedIndex = x - 1;//删除后选中上一个选项


                }
            }
            else
            {
                log.AppendText("未选中需要删除的文件,请重试\r\n");
            }
        }

        private void btnSaveTxt_Click(object sender, EventArgs e)
        {
            string[] str = log.Text.Replace("\r\n", "\n").Split('\n');
            for (int i = 0; i < str.Length; i++)
            {
                adbCmd("shell \" echo " + str[i] + " >" + (i == 0 ? "" : ">") + " storage/emulated/0/_Zip/file/temp.txt" + "\"");
            }

            //log.AppendText(adbCmd("shell \" echo " + str + " > storage/emulated/0/_Zip/file/temp.txt" + "\"") + "\r\n");

        }
        private void QuickPath_Click(object sender, EventArgs e)
        {
            /* if (((MouseEventArgs)e).Button == MouseButtons.Right)
             {
                 PathDialog p = new PathDialog(((Label)sender).Text, ((string)((Label)sender).Tag));
                 if (p.ShowDialog() == DialogResult.OK)
                 {
                     log.AppendText(p.Title + "\r\n" + p.Path);
                 }
                 p.Dispose();
             }
             else*/
            {
                //log.AppendText(((string)((Button)sender).Tag) + "\r\n");
                adbList(((string)((Button)sender).Tag));
            }
        }

        private void MenuQuickPath_Opening(object sender, CancelEventArgs e)
        {
            if ((sender as ContextMenuStrip).SourceControl.Name.Equals(panelQuickPathList.Name))
            {
                设置ToolStripMenuItem.Enabled = false;
                删除ToolStripMenuItem.Enabled = false;
            }
            else
            {
                设置ToolStripMenuItem.Enabled = true;
                删除ToolStripMenuItem.Enabled = true;
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button b = (Button)((ContextMenuStrip)(((ToolStripMenuItem)sender).GetCurrentParent())).SourceControl;
            PathDialog p = new PathDialog(b.Text, ((string)b.Tag));
            if (p.ShowDialog() == DialogResult.OK)
            {
                path_save_flag = true;
                b.Text = p.Title;
                b.Tag = p.Path;
                toolTip1.SetToolTip(b, (string)b.Tag + "\r\n右键菜单设置");
            }
            p.Dispose();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path_save_flag = true;
            ListQuickPath.Add(newPathButton("快捷路径", Path.Text));
            _ListQuickPath_Layout();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            path_save_flag = true;
            Button b = (Button)((ContextMenuStrip)(((ToolStripMenuItem)sender).GetCurrentParent())).SourceControl;
            ListQuickPath.Remove(b);
            _ListQuickPath_Layout();
        }
    }
}
