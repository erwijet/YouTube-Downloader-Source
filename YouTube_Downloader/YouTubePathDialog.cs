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
    public partial class YouTubePathDialog : Form
    {
        public string FilePathReturned { get; set; }

        public YouTubePathDialog()
        {
            InitializeComponent();
            this.FormClosed += new FormClosedEventHandler(FormIsClosing);
        }

        private void FormIsClosing(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK)
                this.DialogResult = DialogResult.Cancel;
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            this.FilePathReturned = textBox1.Text;
            this.DialogResult = DialogResult.OK;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
