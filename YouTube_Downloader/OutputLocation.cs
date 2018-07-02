using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace YouTube_Downloader
{
    public class OutputLocation
    {
        public enum OutputType
        {
            FTP,
            File_Location
        }

        public NetworkCredential creds { get; set; }
        public OutputType Type { get; set; }
        public String Path { get; set; }

        public OutputLocation(OutputType @OutputType, string Path)
        {
            this.Type = OutputType;
            this.Path = Path;
        }

        public static OutputLocation CreateFromString(string OutputLocationString)
        {
            //Decode String
            string path = "";
            OutputLocation ol = new OutputLocation(OutputType.File_Location, "");
            OutputType ot = OutputType.File_Location;
            if (OutputLocationString.Substring(0, "##".Length) == "L#")
            {
                path = OutputLocationString.Substring("##".Length);
                ol.Type = OutputType.File_Location;
            }
            else
            {
                path = OutputLocationString.Substring(OutputLocationString.IndexOf(";") + 1);
                ol.Type = OutputType.FTP;

                string usr = "";
                string pas = "";
                foreach (char thisChar in OutputLocationString.Substring("F#".Length))
                {
                    if (thisChar != '@')
                        usr += thisChar.ToString();
                    else
                        break;
                }
                foreach (char thisChar in OutputLocationString.Substring("F#".Length + usr.Length + 1, OutputLocationString.IndexOf(';') + 1))
                {
                    if (thisChar != ';')
                        pas += thisChar.ToString();
                    else break;
                }
                ol.creds = new NetworkCredential(usr, pas);
            }
            ol.Path = path;
            //ol.Type = ot;
            return ol;
        }

        public override string ToString()
        {
            //Encode String
            string returns = "";
            if (this.Type == OutputType.File_Location)
                returns += "L#";
            else
            {
                returns += "F#";
                returns += creds.UserName + "@" + creds.Password + ";";
            }
            returns += this.Path;
            return returns;
        }
    }
}
