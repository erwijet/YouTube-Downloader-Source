using System;
using System.Net;
using System.IO;
using VideoLibrary;

namespace YouTube_Downloader
{
    public static class TestingToolkit
    {
        public static bool FileExists(string path) => File.Exists(path);
        public static bool YoutubePathExists(string path)
        {
            try
            {
                YouTube youtube = new YouTube();
                var vid = youtube.GetVideo(path);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool TestNetwork()
        {
            try
            {
                WebClient c = new WebClient();
                c.DownloadData("https://www.google.com/images/branding/googlelogo/2x/googlelogo_color_120x44dp.png");
                c.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
