using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaToolkit;
using MediaToolkit.Model;
using VideoLibrary;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;

namespace YouTube_Downloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ll_editfilepath.Click += new EventHandler(EditFilePath);
            ll_editYoutubePath.Click += new EventHandler(EditYoutubePath);
            rb_youtube.CheckedChanged += new EventHandler(RadioButtonUpdate);
            btn_add.Click += new EventHandler(OutputListAddItem);
            listBox2.SelectedIndexChanged += new EventHandler(OutputsSelectionChanged);
            btn_edit.Click += new EventHandler(EditOutput);
            btn_del.Click += new EventHandler(DeleteOutput);
            ll_createYPS.Click += new EventHandler(ToolStart_YPS);
            btn_convert.Click += new EventHandler(DoConvert);
            this.Load += new EventHandler(LoadMe);
            ll_testNetwork.Click += new EventHandler(LoadNetTest);
            ll_testVideo.Click += new EventHandler(ShowVideoTester);
        }

        public MainForm(string path)
        {
            InitializeComponent();
            ll_editfilepath.Click += new EventHandler(EditFilePath);
            ll_editYoutubePath.Click += new EventHandler(EditYoutubePath);
            rb_youtube.CheckedChanged += new EventHandler(RadioButtonUpdate);
            btn_add.Click += new EventHandler(OutputListAddItem);
            listBox2.SelectedIndexChanged += new EventHandler(OutputsSelectionChanged);
            btn_edit.Click += new EventHandler(EditOutput);
            btn_del.Click += new EventHandler(DeleteOutput);
            ll_createYPS.Click += new EventHandler(ToolStart_YPS);
            btn_convert.Click += new EventHandler(DoConvert);
            ll_testNetwork.Click += new EventHandler(LoadNetTest);
            ll_testVideo.Click += new EventHandler(ShowVideoTester);
            this.Load += new EventHandler(LoadMe);

            if (File.Exists(path) && (new FileInfo(path)).Extension == ".yps")
            {
                using (FileStream s = File.OpenRead(path))
                {
                    try
                    {
                        BinaryFormatter bin = new BinaryFormatter();
                        List<InputSource> TestStructure = bin.Deserialize(s) as List<InputSource>;
                        TestStructure = null;

                        //VALID FILE - CONTINUE

                        l_filepath.Text = path;
                        rb_yps.Checked = true;
                    }
                    catch
                    {
                        MessageBox.Show($"Error!: {path} is invalid.\nThe application will new close.");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show($"Error!: {path} is not an existing .yps file.\nThe application will now close.");
                this.Close();
            }

        }

        public void GetMediaFromYoutube(string path, int mode, OutputLocation[] sources)
        {
            try
            {
                foreach (OutputLocation ol in sources)
                {
                    //var source = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\";
                    if (ol.Type == OutputLocation.OutputType.File_Location)
                    {
                        string source = ol.Path + @"\";
                        var youtube = YouTube.Default;
                        var vid = youtube.GetVideo(path);
                        LogInfo($"Downloading \'{vid.FullName}\'...");
                        File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                        var inputFile = new MediaFile { Filename = source + vid.FullName };
                        var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                        LogInfo($"Extracting... [{vid.Title}]");

                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);

                            engine.Convert(inputFile, outputFile);
                        }

                        //                filename = outputFile.Filename;

                        LogInfo($"Cleaning Up... [{vid.Title}]");
                        switch (mode)
                        {

                            case 0:
                                File.Delete(outputFile.Filename.Substring(0, outputFile.Filename.Length - ".mp3".Length));
                                break;
                            case 1:
                                File.Delete(outputFile.Filename);
                                break;
                            case 2:
                                break;
                        }
                        LogInfo($"Done! [{vid.Title}]");
                    }
                    else
                    {
                        string source = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\";
                        var youtube = YouTube.Default;
                        var vid = youtube.GetVideo(path);
                        LogInfo($"Downloading \'{vid.FullName}\'...");
                        File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

                        var inputFile = new MediaFile { Filename = source + vid.FullName };
                        var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

                        LogInfo($"Extracting... [{vid.Title}]");

                        using (var engine = new Engine())
                        {
                            engine.GetMetadata(inputFile);

                            engine.Convert(inputFile, outputFile);
                        }

                        //                filename = outputFile.Filename;

                        LogInfo($"Cleaning Up... [{vid.Title}]");

                        string formatName = "";
                        foreach (char c in vid.FullName)
                        {
                            if (c != ' ')
                                formatName += c.ToString();
                            else
                                formatName += '-'.ToString();
                        }
                        WebClient client = new WebClient();
                        switch (mode)
                        {
                            case 0:
                                formatName = "";
                                foreach (char c in vid.FullName.Substring(0, vid.FullName.Length - ".mp4".Length))
                                {
                                    if (c != ' ')
                                        formatName += c.ToString();
                                    else
                                        formatName += '-'.ToString();
                                }
                                client.Credentials = ol.creds;
                                File.Delete(outputFile.Filename.Substring(0, outputFile.Filename.Length - ".mp3".Length));
                                LogInfo($"Preparing to connect... [{vid.Title}]");
                                client.Credentials = ol.creds;
                                File.Move(source + vid.FullName + ".mp3", source + formatName.Substring(0, formatName.Length - ".mp4".Length) + ".mp3");
                                try
                                {
                                    LogInfo($"Connecting... [{vid.Title}]");
                                    LogInfo($"Uploading... [{vid.Title}]");
                                    client.UploadFile(new Uri(ol.Path + "/" + formatName.Substring(0, formatName.Length - ".mp4".Length) + ".mp3"), source + formatName.Substring(0, formatName.Length - ".mp4".Length) + ".mp3");
                                    LogInfo($"Done! [{vid.Title}]");
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("ERROR! " + ex.ToString());
                                }
                                break;
                            case 1:
                                File.Delete(outputFile.Filename);
                                LogInfo($"Preparing to connect... [{vid.Title}]");
                                client.Credentials = ol.creds;
                                File.Move(source + vid.FullName, source + formatName);
                                try
                                {
                                    LogInfo($"Connecting... [{vid.Title}]");
                                    LogInfo($"Uploading... [{vid.Title}]");
                                    client.UploadFile(new Uri(ol.Path + "/" + formatName), source + formatName);
                                    LogInfo($"Finishing... [{vid.Title}]");
                                    File.Delete(source + formatName);
                                    LogInfo($"Done! [{vid.Title}]");
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("ERROR! " + ex.ToString());
                                }
                                break;
                            case 2:
                                LogInfo($"Preparing to connect... [{vid.Title}]");
                                client.Credentials = ol.creds;
                                File.Move(source + vid.FullName, source + formatName);
                                try
                                {
                                    LogInfo($"Connecting... [{vid.Title}]");
                                    LogInfo($"Uploading... [{vid.Title}]");
                                    client.UploadFile(new Uri(ol.Path + "/" + formatName), source + formatName);
                                    string vidToDel = formatName;
                                    formatName = "";
                                    foreach (char c in vid.FullName + ".mp3")
                                    {
                                        if (c != ' ')
                                            formatName += c.ToString();
                                        else
                                            formatName += '-'.ToString();
                                    }
                                    File.Move(source + vid.FullName + ".mp3", source + formatName);
                                    client.UploadFile(new Uri(ol.Path + "/" + formatName), source + formatName);
                                    LogInfo($"Finishing... [{vid.Title}]");
                                    File.Delete(source + formatName);
                                    File.Delete(source + vidToDel);
                                    LogInfo($"Done! [{vid.Title}]");
                                }
                                catch (Exception ex)
                                {
                                    LogInfo("ERROR! " + ex.Message);
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogInfo("Error!: " + ex.Message);
                //filename = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
        }
    }
}
