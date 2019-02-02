using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroToCSharp
{
    class ConsoleLogger : ILogger
    {
        public int SeverityMin { get; set; }

        public void Log(string message, int severity)
        {
            Console.WriteLine("SEVERITY " + severity.ToString() + ": " + message);
        }

        public void Assert(bool condition, string message, int severity)
        {
            Console.WriteLine("[" + condition + "] " + "SEVERITY " + severity.ToString() + ": " + message);
        }
    }
}
