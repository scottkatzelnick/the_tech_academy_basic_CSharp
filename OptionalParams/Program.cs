using System;

namespace OptionalParams
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Maths function = new Maths();
            string paramOne;
            string paramTwo = null;
            do
            {
                Console.Write("Enter first number\n>>>: ");
                paramOne = Console.ReadLine();

                try
                {
                    if (paramOne == "")
                    {
                        Console.WriteLine("\nThe first number is required for the function to run.\n\nPlease try again,");
                    }
                    else
                    {
                        Console.Write("\nEnter second number, if you wish, as this number is not required like the first\n>>>: ");
                        paramTwo = Console.ReadLine();

                        if (paramTwo == "" || paramTwo == "0" || paramOne == "0")
                        {
                            if (paramOne != "0" && paramTwo != "0")
                            {
                                int result = function.DoubleInOneOut(paramOne);
                                Console.WriteLine($"\nSince only one number was given, {paramOne}, we apply the second function,\n");
                                Console.WriteLine("The product of the quotient of the product of the sums of the difference equates to {0}!", result);
                                Console.WriteLine("That is (numOne + numOne + numOne * numOne / numOne - numOne) * numOne just to visualize it better!");
                                paramOne = "Leave Loop";
                                paramTwo = "Leave Loop";
                            }
                            else
                            {
                                Console.WriteLine("\nPlease enter a number greater than zero!");
                            }
                        }
                        else
                        {
                            int result = function.DoubleInOneOut(paramOne, paramTwo);
                            Console.WriteLine($"\nSince two numbers were given, {paramOne} and {paramTwo}, we apply the first function,\n");
                            Console.WriteLine("The product of the quotients of the sum over each number equates to {0}!", result);
                            Console.WriteLine("That is (numOne + numTwo) / numOne * ((numOne + numTwo) / numTwo) just to visualize it better!");
                            paramOne = "Leave Loop";
                            paramTwo = "Leave Loop";
                        }
                    }
                }
                catch (FormatException err)
                {
                    Console.WriteLine($"\nOopps, looks like you didn't enter a valid number for one or both of your input(s)\nError: {err.Message}");
                }
            } while (paramOne == "" || paramOne == "0" || paramTwo == "0");
        }
    }
}
