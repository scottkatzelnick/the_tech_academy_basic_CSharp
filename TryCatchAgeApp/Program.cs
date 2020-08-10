using System;

namespace TryCatchAgeApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            bool isAgeValid = false;
            while (!isAgeValid)
            {
                Console.Write("What is your current age?\n>>>: ");
                try
                {
                    isAgeValid = int.TryParse(Console.ReadLine(), out int age);
                    if (isAgeValid == false)
                    {
                        throw new Exception();
                    }
                    else
                    {
                        ConvertAge convertAge = new ConvertAge();
                        int birthYear = convertAge.FindYear(age);
                        Console.WriteLine($"\nYou were born in {birthYear} or {birthYear - 1}, depending on when your actual Birthdate was!");
                    }
                }
                catch (ZeroException)
                {
                    Console.WriteLine("\nYou need to enter an age greater than 0!\n");
                    isAgeValid = false;
                }
                catch (Exception err)
                {
                    Console.WriteLine($"\nYou need to enter a valid interger.\nError: {err.Message}\nPlease try again!\n");
                    isAgeValid = false;
                }
            }
            Console.Read();
        }
    }
}
