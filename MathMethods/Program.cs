using System;

namespace MathMethods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Please enter a number to preform a few cool math operations on . . .\n>>>: ");
            float userInt = Convert.ToInt64(Console.ReadLine());

            float firstNum = Operations.SelfLimit(userInt);
            float secondNum = Operations.PowerHour(userInt);
            double seconds = Convert.ToDouble(Operations.TimeFlies(userInt));
            DateTime time = DateTime.Now;
            DateTime futuretime = time.AddSeconds(seconds);
            Console.WriteLine($"\nThe Limit of {userInt} as you appraoch it from the left after 4 passes is {firstNum}!");
            Console.WriteLine($"\n{userInt} to the power of itself is {secondNum}!");
            Console.WriteLine($"\nIf you add {userInt} seconds to the time right now you'd end up at {futuretime:MMM dd, yyyy, hh:mm:ss tt}!");
            Console.ReadLine();
        }
    }
}
