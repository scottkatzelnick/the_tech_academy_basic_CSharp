using System;

namespace myConsoleProject
{
    class Program
    {
        static void Main()
        {
            
            
            // Welcome Message
            string welcomeMsg_0 = "Welcome to Acme Accounting Systems";
            string welcomeMsg_1 = "Remember, we’re “accounting” on you!";
            Console.WriteLine(welcomeMsg_0 + "\n" + welcomeMsg_1);
            Console.WriteLine("\nEnter to continue . . . ");
            Console.Read();
            
            // Using Read()/ReadLine() methods
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + "!");
            Console.WriteLine("\nEnter to Exit . . . ");
            Console.Read();
        }
    }
}
