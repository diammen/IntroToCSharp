using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Globalization;

namespace IntroToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // (?<=;color\s

            string input = "";
            string name = "bro";
            string[] filteredList = { "fuck", "cunt", "heck", "shit", "bitch" };

            bool quit = false;

            ConsoleLogger logger = new ConsoleLogger();
            TextLogger txtLog = new TextLogger();

            object obj = new Random().Next(2) == 0 ? new BaseClass() : new DerivedClass();

            Console.WriteLine("Class chosen=" + obj.GetType());

            Console.WriteLine("Enter a name:");
            name = Console.ReadLine();
            Console.Clear();

            while (!quit)
            {
                input = Console.ReadLine();
                input = filterWord(input, filteredList);
                if (input[0] == ';')
                {
                    string commandType = @";\w+";
                    Regex typeRgx = new Regex(commandType, RegexOptions.IgnoreCase);

                    string commandPattern = @"[^;color + \s*].+";
                    string tempPattern = @"\w+";
                    Regex commandRgx = new Regex(commandPattern, RegexOptions.IgnoreCase);
                    Regex tempRgx = new Regex(tempPattern, RegexOptions.IgnoreCase);
                    string command = tempRgx.Match(input).ToString();

                    switch (command)
                    {
                        case "quit":
                            quit = true;
                            break;
                        case "color":
                            string arg = commandRgx.Match(input).ToString();

                            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

                            arg = textInfo.ToTitleCase(arg);

                            ConsoleColor color;
                            if (Enum.TryParse(arg, out color))
                            {
                                Console.ForegroundColor = color;
                            }
                            else
                            {
                                logger.Log("Invalid color", 1);
                            }
                            break;
                        case "colorlist":
                            var colors = Enum.GetValues(typeof(ConsoleColor));
                            foreach (int i in colors)
                            {
                                Console.WriteLine(colors.GetValue(i).ToString());
                            }
                            break;
                        case "help":

                            break;
                        default:
                            logger.Log("Expected command", 1);
                            txtLog.Log("Expected command", 1);
                            txtLog.Assert(false, "Expected command", 1);
                            break;
                    }
                }
                else
                {
                    Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                    ClearLine();
                    Console.WriteLine(name + ": " + input);
                }
            }
        }

        static void ClearLine()
        {
            Console.Write("\b");
        }

        static string filterWord(string input, string[] list)
        {
            for (int i = 0; i < list.Length; ++i)
            {
                string pattern = @"\b" +  string.Join(@"{1,}\s*", list[i].ToCharArray())+ @"{1,}\b";
                Regex regex = new Regex(pattern, RegexOptions.IgnoreCase);
                input = regex.Replace(input, match => {return new string('#', match.Length); });

            }
            return input;
        }

        static string searchRepeating(string str)
        {
            char[] temp = str.ToCharArray();
            //"bad" = b/s*a/s*d
            //"bad" = b{1,}/s*a{1,}/s*d{1,}
            return str;
        }
    }
}
