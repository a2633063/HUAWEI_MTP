using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTP
{
    public partial class PathDialog : Form
    {
        public PathDialog(string _title, string _path)
        {
            InitializeComponent();
            button1.DialogResult = DialogResult.OK;
            button2.DialogResult = DialogResult.Cancel;

            this.Path = _path;
            this.Title = _title;

        }

        public string Title
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }

        public string Path
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }
    }
}
