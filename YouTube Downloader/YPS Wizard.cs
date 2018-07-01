using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace YouTube_Downloader
{
    public partial class YPS_Wizard : Form
    {
        //public List<InputSource> sources { get; set; }
        public BindingList<InputSource> sources { get; set; }

        public YPS_Wizard()
        {
            InitializeComponent();
            sources = new BindingList<InputSource>();
            dataGridView1.DataSource = sources;
        }

        private void YPS_Wizard_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sources.Add(new InputSource("http://www.youtube.com/", InputSource.SaveType.Audio));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
             //   int removeIndex = sources.IndexOf(new InputSource(row.Cells[0].Value.ToString(), (InputSource.SaveType)row.Cells[1].Value));
                foreach (DataGridViewRow rows in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(rows.Index);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "YouTube Path Set|*.yps";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    List<InputSource> inputs = new List<InputSource>();
                    foreach (InputSource src in sources)
                    {
                        inputs.Add(src);
                    }
                    BinaryFormatter bin = new BinaryFormatter();
                    using (FileStream s = File.Create(sfd.FileName))
                    {
                        bin.Serialize(s, inputs);
                    }
                    MessageBox.Show("YPS file export finished");
                }
            }
        }
    }

    [Serializable]
    public class InputSource
    {
        public enum SaveType
        {
            Audio,
            Video,
            Mixed
        }

        public string Url { get; set; }
        public SaveType ExportAs { get; set; }

        public InputSource(string path, SaveType saveType)
        {
            this.Url = path;
            this.ExportAs = saveType;
        }
    }
}
