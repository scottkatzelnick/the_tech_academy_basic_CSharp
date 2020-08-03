using System;

namespace DoubleDown
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Instantiate class
            Multiplier function = new Multiplier();

            //Get input from user and pass to Multiplier method
            Console.Write("Please enter a number\n>>>: ");
            int input = Convert.ToInt32(Console.ReadLine());

            // Initialize output
            int result;

            // Call method
            function.Double(input, out result);

            // Print result to console
            Console.WriteLine($"\nAnswer 1: {result}");

            // Initialize output
            string newNum;

            // Call overloaded method from static class
            Fixed.Double(input, out newNum);

            // Print out parameter from void method
            Console.WriteLine($"\nAnswer 2: {newNum}");
            Console.ReadLine();
        }
    }
}
