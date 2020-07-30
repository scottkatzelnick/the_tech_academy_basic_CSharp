using System;
using System.Globalization;

namespace PackageMasters
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Masters! Please follow the instructions below.");

            Console.Write("Please Enter Package Weight (lbs.)\n>>>: ");
            double packWeight = Convert.ToDouble(Console.ReadLine());

            if (packWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Masters. Have a good day.");
                Console.Write("Enter to exit. . .");
                Console.Read();
            }
            else
            {
                Console.Write("Please Enter Package Width (inches)\n>>>: ");
                double packWidth = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please Enter Package Height (inches)\n>>>: ");
                double packHeight = Convert.ToDouble(Console.ReadLine());

                Console.Write("Please Enter Package Length (inches)\n>>>: ");
                double packLength = Convert.ToDouble(Console.ReadLine());

                double packDimensions = packWidth * packHeight * packLength;
                double packageValidate = packWidth + packHeight + packLength;

                if (packageValidate > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Masters. Have a good day.");
                    Console.Write("Enter to exit. . .");
                    Console.Read();
                }
                else
                {
                    string quote = $"Your estimated total for shipping this package is: {((packDimensions * packWeight) / 100).ToString("C", CultureInfo.CurrentCulture)}";
                    Console.WriteLine(quote + "\nThank you!");
                }
            }
        }
    }
}
