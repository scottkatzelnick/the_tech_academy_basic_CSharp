using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Take input and initialize a variable
            Console.Write("Guess a number?\n>>>: ");
            int num = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = num == 12;

            do
            {
                // Switch Statement
                switch (num)
                {
                    case int n when (n >= 0 && n <= 11) || (n >= 13 && n <= 19):
                        Console.WriteLine("Your guess is 'very' close. Try again!");
                        Console.Write("Guess a number?\n>>>: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12! That is correct!");
                        isGuessed = true;
                        break;
                    case int n when n >= 20 && n <= 29:
                        Console.WriteLine($"Your guess is 'sort of' close. Try again!");
                        Console.Write("Guess a number?\n>>>: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                    case int n when n >= 30:
                        Console.WriteLine("Your guess is way to high. Try again!");
                        Console.Write("Guess a number?\n>>>: ");
                        num = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);

            Console.WriteLine("Congrats!!!!\nEnter to quit");
            Console.Read();
        }
    }
}