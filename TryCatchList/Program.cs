using System;
using System.Collections.Generic;

namespace TryCatchList
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> numList = new List<int>()
            {
                20,
                33,
                57,
                17,
                12,
                2,
                9,
                31,
                88
            };

            try
            {
                Console.Write("Write a number to divide a list of numbers by\n>>>: ");
                int userInt = Convert.ToInt32(Console.ReadLine());

                foreach (int num in numList)
                {
                    int listInt = Convert.ToInt32(num);
                    int quotient = num / userInt;
                    Console.WriteLine($"{num} divided by {userInt} = {quotient}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Enter to continue . . .");
                Console.ReadLine();
            }

            Console.WriteLine("The grass is most certainly greener over here!");
        }
    }
}
