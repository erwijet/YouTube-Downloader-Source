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
    public partial class VideoTester : Form
    {
        public VideoTester()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if (TestingToolkit.YoutubePathExists(tb_urlPath.Text))
            {
                MessageBox.Show($"{tb_urlPath.Text} is a valid YouTube url.\nLet the fun begin!");
            }
            else
            {
                MessageBox.Show($"{tb_urlPath.Text} is not a valid YouTube url.\nSorry, try again.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
