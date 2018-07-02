using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace YouTube_Downloader
{
    public partial class Network_Test : Form
    {
        public Network_Test()
        {
            InitializeComponent();
        }

        private void btn_ping_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "ping.exe";
            process.StartInfo.Arguments = "-n 1 google.com";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();

            // Synchronously read the standard output of the spawned process. 
            StreamReader reader = process.StandardOutput;
            string output = reader.ReadToEnd();

            process.WaitForExit();

            l_traceback.Items.Add(output);
            process.Close();
        }
        void traceback (object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            l_traceback.Items.Add(e.Data);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
