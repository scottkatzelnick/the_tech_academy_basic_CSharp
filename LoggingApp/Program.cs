using System;
using System.IO;
using System.Text;

namespace Log
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please give a number between 0 and 1,000,000!\n>>>: ");
            string inputNum = Console.ReadLine();

            using (StreamWriter file = new StreamWriter(@"C:\Users\Scott Katzelnick\logs\num_log.txt", true))
            {
                file.WriteLine(inputNum + "\n");
                Console.WriteLine("Press Enter please. . . ");
                Console.ReadLine();
            }
            var path = @"C:\Users\Scott Katzelnick\logs\num_log.txt";
            string content = File.ReadAllText(path, Encoding.UTF8);
            Console.WriteLine(content);
            Console.ReadLine();
        }
    }
}
