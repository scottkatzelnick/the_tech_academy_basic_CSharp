using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy\nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();

            Console.WriteLine("What page number?");
            string pageNum_string = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNum_string);

            Console.WriteLine("Do you need help with anyhting?\n(answer 'true', or 'false' only)");
            string help_string = Console.ReadLine();
            bool help = Convert.ToBoolean(help_string);

            Console.WriteLine("Where there any positive experiences you'd like to share? Please give specifics.");
            string studentExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string studentHours_string = Console.ReadLine();
            int studentHours = Convert.ToInt32(studentHours_string);

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();

            //Remove comment lines below for an output of the answered questions:

            //Console.WriteLine("Test:\n");
            //Console.WriteLine(studentName + "\n" + courseName + "\n" + pageNum + "\n" + help + "\n" + studentExp
            //    + "\n" + studentFeedback + "\n" + studentHours);
            //Console.ReadLine();
        }
    }
}
