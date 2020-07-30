using System;

namespace Branching
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int roomTemperature = 70;

            Console.Write("Please pick a temperature to compare:\n>>>: ");

            int currentTemperature = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n");

            // Ternary operator branching
            string comparisonResult = currentTemperature == roomTemperature ? $"It's exactly room temperature!" : "It's not quite room temperature.";
            Console.WriteLine(comparisonResult);

            Console.Write("\n");

            // If/else if/else branching
            if (currentTemperature == roomTemperature)
            {
                Console.WriteLine($"It's exactly {currentTemperature}ºF.");
            }
            else if (currentTemperature > roomTemperature)
            {
                Console.WriteLine($"The temperature of {currentTemperature}ºF is warmer than {roomTemperature}ºF.");
            }
            else if (currentTemperature < roomTemperature)
            {
                Console.WriteLine($"The temperature of {currentTemperature}ºF is cooler than {roomTemperature}ºF.");
            }
            else
            {
                Console.WriteLine($"{currentTemperature}ºF is not quite {roomTemperature}ºF, room temperature.");
            }

            Console.Read();
        }
    }
}
