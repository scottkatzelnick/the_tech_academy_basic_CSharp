using System;

namespace MathAndComparisonOperators
{
    class Program
    {
        // New main method
        public static void Main(string[] args)
        {
            // Math Operators:

            // Addition
            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combinedTotal = total + otherTotal;
            Console.WriteLine(combinedTotal);
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();

            // Subtraction
            int difference = 10 - 5;
            Console.WriteLine($"Ten minus five = {difference}");
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();

            // Multiplication
            int product = 10 * 5;
            Console.WriteLine($"Ten times five = {product}");
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();

            // Division                                             
            double quotient = 100.00 / 17.00;
            Console.WriteLine(quotient);
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();

            // Modulus
            int remainderEven = 10 % 2;
            int remainderOdd = 11 % 2;
            Console.WriteLine(remainderEven + "\n" + remainderOdd);
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();


            // Comparison Operators:

            // Boolean
            bool trueOrFalse = 12 > 5;
            bool falseOrTrue = 12 < 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.WriteLine(falseOrTrue.ToString());
            Console.WriteLine("Press Enter to Continue . . . ");
            Console.ReadLine();

            int roomTemp = 70;
            int currentTemp = 72;

            bool isWarm = currentTemp > roomTemp;
            bool isWarmOrEqual = currentTemp >= roomTemp;
            bool isWarmExact = currentTemp == roomTemp;
            bool isWarmNotExact = currentTemp != roomTemp;
            Console.WriteLine(isWarm);
            Console.WriteLine(isWarmOrEqual);
            Console.WriteLine(isWarmExact);
            Console.WriteLine(isWarmNotExact);
            Console.WriteLine("Press Enter to End . . . ");
            Console.ReadLine();

        }
    }
}
