using System;

namespace Structs
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Number number = new Number()
            {
                Amount = 1.5m
            };

            Console.WriteLine(number.Amount);
            Console.ReadLine();
        }
    }
}
