using System;
using System.Text;

namespace StringFunctions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Noraml String
            string name = "Scott";
            Console.WriteLine(name);

            // String with escape sequences denoting new line and tab (\r carriage return available)
            string quote = "The man said, \"Hello, Scott.\"\nHello on a new line.\n\tHello on a new line with a tab.";
            Console.WriteLine(quote);

            // String using escape sequences on forward slashes
            string filename = "Users\\Scott\\Documents";
            Console.WriteLine(filename);

            // SVerbatim String Literal
            string noEscapes = @"Users\Scott\Documents";
            Console.WriteLine(noEscapes);

            //Verbatim String Literal with double quotes (the one exception)
            string exception = @"Hello there, can I say, ""It's fun to code!""";
            Console.WriteLine(exception);

            // String Methods
            bool trueOrFalse = name.Contains("S");
            Console.WriteLine(trueOrFalse);

            bool trueOrFalse_2 = name.EndsWith("tt");
            Console.WriteLine(trueOrFalse_2);

            int strLength = name.Length;
            Console.WriteLine(strLength);

            name = name.ToUpper();
            Console.WriteLine(name);

            name = name.ToLower();
            Console.WriteLine(name);

            // ** NOTE ** Strings are immutable. They cannot be changed. Each time you "append" a
            // string, you are just creating a new space in memory. You can run into a situation
            // where your program will start to slow down if you have a string, or strings that keep
            // being created by string methods savings new positions in memory every time. C#
            // accounts for this and has a builtin Object called StringBuilder. It creates a
            // "buffer" of sorts. A string that isn't immutable and can be expanded, collapsed, or
            // apended in any way without taking up valuable memory positions. This results in
            // programs that are much more responsive and won't slow down due to the expensive
            // memory overhead costs of the normal "string" data type. (See Example Below)

            // Create a new instance of a StringBuilder
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Scott.");

            Console.WriteLine(sb);
        }
    }
}
