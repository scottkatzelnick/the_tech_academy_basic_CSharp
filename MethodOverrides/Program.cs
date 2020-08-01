using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrides
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Instaniate the Overrides class and call first method
            Overrides overrides = new Overrides();
            int firstResult = overrides.SelfOperate(input: 10);

            // Print result to console
            Console.WriteLine($"Any number added and then divided by itself will always equal {firstResult}!");

            // Instantiate the Overrides class and call the second method
            Overrides overrides1 = new Overrides();
            int secondResult = overrides1.SelfOperate(decInput: 10.1999f);

            // Print result to console
            Console.WriteLine($"{secondResult} is the prodcut of multiplying the decimal 10.1999 by itself!");

            // Instantiate the Overrides class and call the third method
            Overrides overrides2 = new Overrides();
            int thirdResult = overrides2.SelfOperate(strInput: "1o");

            // Print result to console
            if (thirdResult == 0)
            {
                Console.WriteLine($"You know if a number is even if it's modulus returns {thirdResult}!");
            }
            else if (thirdResult == 1)
            {
                Console.WriteLine($"You know if a number is odd if it's modulus returns {thirdResult}!");
            }
            else
            {
                Console.WriteLine("Oooppss, a valid integer must not have been given!");
            }
        }
    }
}
