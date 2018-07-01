using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YouTube_Downloader
{
    public partial class Output_Designer : Form
    {
        public OutputLocation ol { get; set; }

        public Output_Designer()
        {
            InitializeComponent();
            ol = new OutputLocation(OutputLocation.OutputType.File_Location, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public Output_Designer(string code)
        {
            InitializeComponent();
            ol = OutputLocation.CreateFromString(code);
            tb_path.Text = ol.Path;
            if (ol.Type == OutputLocation.OutputType.File_Location)
                rb_folder.Checked = true;
            else
            {
                rb_ftp.Checked = true;
                gb_login.Visible = true;
                try
                {
                    tb_pass.Text = ol.creds.Password;
                    tb_user.Text = ol.creds.UserName;
                }
                catch { }
            }

        }

        private void Output_Designer_Load(object sender, EventArgs e)
        {
            //ol = new OutputLocation(OutputLocation.OutputType.File_Location, Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
        }

        public string GetOutputLocationString() => ol.ToString();

        private void rb_folder_CheckedChanged(object sender, EventArgs e)
        {  
            if (rb_folder.Checked)
            {
                ol.Type = OutputLocation.OutputType.File_Location;
                gb_login.Visible = false;
                ll_browse.Enabled = true;
            }
            else
            {
                ol.Type = OutputLocation.OutputType.FTP;
                gb_login.Visible = true;
                ll_browse.Enabled = false;
            }
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            ol.Path = tb_path.Text;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            if (rb_ftp.Checked)
                ol.creds = new System.Net.NetworkCredential (tb_user.Text, tb_pass.Text);
            this.DialogResult = DialogResult.OK;
        }

        private void ll_browse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    tb_path.Text = fbd.SelectedPath;
                }
            }
        }
    }
}
