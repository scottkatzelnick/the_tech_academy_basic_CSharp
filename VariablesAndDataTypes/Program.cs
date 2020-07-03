using System;
#pragma warning disable 219

namespace VariablesAndDataTypes
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //This is a simple program
            //Console.WriteLine("What is your name?");
            //string yourName = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourName);
            //Console.ReadLine();

            //Convert string to int
            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int favNum = Convert.ToInt32(favoriteNumber);
            //int total = favNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            // ReSharper disable once ConvertToConstant.Local
            char questionMark = '\u2103';

            decimal moneyInBank = 100.5m;
            double heightInCentimeters = 211.3012902;

            float secondsLeft = 2.62f;
            short tempOnMars = -341;

            string myName = "Scott";

            //Convert int to string
            int currentAge = 33;
            string yrsOld = currentAge.ToString();

            //Convert bool to string
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();

            Console.WriteLine(questionMark);
            Console.ReadLine();

        }
    }
}
