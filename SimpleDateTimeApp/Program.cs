using System;

namespace SimpleDateTimeApp
{
    // Allow user to add any amount of hours to datetime to see future datetime
    internal class Program
    {
        // Instantiate long string to const to handle readability
        private const string value = "\n\nThe above is the current date and time. Please enter a number and press enter to see what the future datetime would be with your number added!\n>>";

        private static void Main(string[] args)
        {
            // current time
            Console.WriteLine(DateTime.Now);
            Console.Write(value); // Const value displayed to guide user
            double delta = Convert.ToDouble(Console.ReadLine()); // User input to add to current time

            // Create datetime object with user value added
            DateTime newTime = DateTime.Now.AddHours(delta);
            Console.WriteLine($"\nYou added {delta} hour(s) to the current time. The new datetime would be {newTime:MM/dd/yyyy hh:mm:ss tt}!"); // Print to screen in correct date format
            Console.ReadLine();
        }
    }
}
