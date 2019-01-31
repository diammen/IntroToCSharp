using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagingErrors
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            string name = "bro";
            string[] filteredList = { "fuck", "cunt", "heck", "shit", "bitch" };

            Console.WriteLine("Enter a name:");
            name = Console.ReadLine();
            Console.Clear();

            while (input != "quit")
            {
                input = Console.ReadLine();
                input = filterWord(input, filteredList);
                Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
                ClearLine();
                Console.WriteLine(name + ": " + input);
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
                input = input.Replace(list[i], new string('#', list[i].Length));
            }
            return input;
        }
    }
}
