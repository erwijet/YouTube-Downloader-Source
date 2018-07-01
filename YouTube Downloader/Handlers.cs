using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;

namespace YouTube_Downloader
{
    public partial class MainForm
    {
        void RadioButtonUpdate(object sender, EventArgs e)
        {
            if (rb_youtube.Checked)
            {
                cb_singleType.Enabled = true;
                l_filepath_prompt.Enabled = false;
                l_filepath.Enabled = false;
                ll_editfilepath.Enabled = false;

                l_youtubepath_prompt.Enabled = true;
                l_youtubepath.Enabled = true;
                ll_editYoutubePath.Enabled = true;
            }
            else
            {
                cb_singleType.Enabled = false;
                l_filepath_prompt.Enabled = true;
                l_filepath.Enabled = true;
                ll_editfilepath.Enabled = true;

                l_youtubepath_prompt.Enabled = false;
                l_youtubepath.Enabled = false;
                ll_editYoutubePath.Enabled = false;
            }
        }
        void EditYoutubePath(object sender, EventArgs e)
        {
            using (YouTubePathDialog ypd = new YouTubePathDialog())
            {
                ypd.ShowDialog();
                if (ypd.DialogResult == DialogResult.OK)
                {
                    if (TestingToolkit.YoutubePathExists(ypd.FilePathReturned))
                        l_youtubepath.ForeColor = Color.Green;
                    else
                        l_youtubepath.ForeColor = Color.Red;
                    l_youtubepath.Text = ypd.FilePathReturned;
                }
            }
        }
        void EditFilePath(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "YouTube Path Set|*.yps";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (TestingToolkit.FileExists(ofd.FileName))
                        l_filepath.ForeColor = Color.Green;
                    else
                        l_filepath.ForeColor = Color.Red;
                    l_filepath.Text = ofd.FileName;
                }
            }
        }
        void OutputListAddItem(object sender, EventArgs e)
        {
            Output_Designer od = new Output_Designer();
            od.ShowDialog();
            if (od.DialogResult == DialogResult.OK)
            {
                listBox2.Items.Add(od.ol.ToString());
                LogInfo("Added new output location");
            }
        }
        void OutputsSelectionChanged(object sender, EventArgs e)
        {
            if ((sender as ListBox).SelectedItems.Count != 0)
            {
                btn_del.Enabled = true;
                btn_edit.Enabled = true;
            }
            else
            {
                btn_del.Enabled = false;
                btn_edit.Enabled = false;
            }
        }
        void EditOutput(object sender, EventArgs e)
        {
            Output_Designer od = new Output_Designer(listBox2.Items[listBox2.SelectedIndex].ToString());
            od.ShowDialog();
            if (od.DialogResult == DialogResult.OK)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
                listBox2.Items.Add(od.ol.ToString());
                LogInfo($"Updated output location [{listBox2.SelectedIndex}]");
            }
        }
        void DeleteOutput(object sender, EventArgs e)
        {
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            LogInfo("Removed output location");
        }
        void ToolStart_YPS(object sender, EventArgs e)
        {
            YPS_Wizard yps = new YPS_Wizard();
            yps.Show();
        }
        void LoadMe(object sender, EventArgs e)
        {
            cb_singleType.SelectedItem = "Audio";
        }
        void DoConvert(object sender, EventArgs e)
        {
            int intCode = 0;
            if (rb_youtube.Checked)
            {
                    switch (cb_singleType.SelectedItem.ToString())
                    {
                        case "Audio":
                            intCode = 0;
                            break;
                        case "Video":
                            intCode = 1;
                            break;
                        case "Mixed":
                            intCode = 2;
                            break;
                    }
                    List<OutputLocation> ols = new List<OutputLocation>();
                    foreach (string code in listBox2.Items)
                    {
                        ols.Add(OutputLocation.CreateFromString(code));
                    }
                    GetMediaFromYoutube(l_youtubepath.Text, intCode, ols.ToArray());
            }
            else
            {
                //Load YPS File
                try
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    using (FileStream s = File.OpenRead(l_filepath.Text))
                    {
                        List<InputSource> fileSorces = bin.Deserialize(s) as List<InputSource>;
                        foreach (InputSource source in fileSorces)
                        {
                            int typeCode = 0;
                            List<OutputLocation> ols = new List<OutputLocation>();
                            foreach (string code in listBox2.Items)
                            {
                                ols.Add(OutputLocation.CreateFromString(code));
                            }
                            //Get typeCode from source enum
                            switch (source.ExportAs)
                            {
                                case InputSource.SaveType.Audio:
                                    typeCode = 0;
                                    break;
                                case InputSource.SaveType.Video:
                                    typeCode = 1;
                                    break;
                                case InputSource.SaveType.Mixed:
                                    typeCode = 2;
                                    break;
                            }

                            LogInfo($"Starting work on \'{source.Url}\'");
                            GetMediaFromYoutube(source.Url, typeCode, ols.ToArray());
                        }
                    }
                }

                catch (Exception ex)
                {
                    LogInfo(ex.ToString());
                }
            }
        }
        void LoadNetTest(object sender, EventArgs e)
        {
            Network_Test nt = new Network_Test();
            nt.Show();
        }
        void ShowVideoTester(object sender, EventArgs e)
        {
            VideoTester vtester = new VideoTester();
            vtester.Show();
        }
    }
}
