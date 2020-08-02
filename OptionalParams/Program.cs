using System;

namespace OptionalParams
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Maths function = new Maths(); // Instantiate class into object

            // Initialize both parameters for while loop
            string paramOne;
            string paramTwo = null;
            do
            {
                // User input 1
                Console.Write("Enter first number\n>>>: ");
                paramOne = Console.ReadLine();

                try
                {
                    if (paramOne == "") // Requires first parameter to be given by user, otherwise repeats loop
                    {
                        Console.WriteLine("\nThe first number is required for the function to run.\n\nPlease try again,");
                    }
                    else
                    {
                        // User input 2 (optional)
                        Console.Write("\nEnter second number, if you wish, as this number is not required like the first\n>>>: ");
                        paramTwo = Console.ReadLine();

                        // Branches into path where only first number is given
                        if (paramTwo == "" || paramTwo == "0" || paramOne == "0")
                        {
                            // Verifies neither number is 0
                            if (paramOne != "0" && paramTwo != "0")
                            {
                                // Calls DoubleInOneOut method for single parameter
                                try
                                {
                                    int result = function.DoubleInOneOut(paramOne);
                                    Console.WriteLine($"\nSince only one number was given, {paramOne}, we apply the second function,\n");
                                    Console.WriteLine("The quotient of the results, added to and subtracted, from each product equates to {0}!", result);
                                    Console.WriteLine($"That is ({paramOne} + {paramOne} * {paramOne}) / ({paramOne} * {paramOne} - {paramOne}) just to visualize it better!");
                                    paramOne = "Leave Loop";
                                    paramTwo = "Leave Loop";
                                }
                                catch (DivideByZeroException err)
                                {
                                    Console.WriteLine($"Whooppss, looks like the function tried to divide by zero according to the System Error: {err.Message}\n");
                                    Console.Write("Let's try that again, this time using a different first number, or entering a second number as well!\n\n");
                                    paramOne = "0";
                                    paramTwo = "0";
                                }
                            }
                            // Loop repeats is either is given as 0
                            else
                            {
                                Console.WriteLine("\nPlease enter a number greater than zero!");
                            }
                        }
                        // Calls DoubleInOneOut for both parameters
                        else
                        {
                            int result = function.DoubleInOneOut(paramOne, paramTwo);
                            Console.WriteLine($"\nSince two numbers were given, {paramOne} and {paramTwo}, we apply the first function,\n");
                            Console.WriteLine("The product of the quotients of the sum over each number equates to {0}!", result);
                            Console.WriteLine($"That is ({paramOne} + {paramTwo}) / {paramOne} * (({paramOne} + {paramTwo}) / {paramTwo}) just to visualize it better!");
                            paramOne = "Leave Loop";
                            paramTwo = "Leave Loop";
                        }
                    }
                }
                // Any format errors are caught and loop repeats
                catch (FormatException err)
                {
                    Console.WriteLine($"\nOopps, looks like you didn't enter a valid number for one or both of your input(s)\nError: {err.Message}\n");
                    paramOne = "0";
                    paramTwo = "0";
                }
                // Loop ends once valid parameters are given
            } while (paramOne == "" || paramOne == "0" || paramTwo == "0");
        }
    }
}
