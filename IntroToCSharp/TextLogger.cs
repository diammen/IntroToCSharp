using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IntroToCSharp
{
    class TextLogger : ILogger
    {
        public int SeverityMin { get; set; }

        public void Log(string message, int severity)
        {
            string path = "Log.txt";
            string time = DateTime.Now.ToString("HH:mm:ss");

            using (FileStream file = File.OpenWrite(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("SEVERITY " + severity.ToString() + ": " + message + " " + time);
                file.Write(info, 0, info.Length);
            }
        }

        public void Assert(bool condition, string message, int severity)
        {
            string path = "Log.txt";
            string time = DateTime.Now.ToString("HH:mm:ss");

            using (FileStream file = File.OpenWrite(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("[" + condition + "] " + "SEVERITY " + severity.ToString() + ": " + message + " " + time);
                file.Write(info, 0, info.Length);
            }
        }
    }
}
