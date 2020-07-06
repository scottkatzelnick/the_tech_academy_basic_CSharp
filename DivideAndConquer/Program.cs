using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic.CompilerServices;

namespace MathOperatorAssignment
{
    class Program
    {
        public static void Main(string[] args)
        {
            TypeIntro(intro);
            Console.WriteLine("\n");

            TypeQuestion1(question1);
            Console.WriteLine("\n");

            TypeQuestion2(question2);
            Console.WriteLine("\n");

            TypeQuestion3(question3);
            Console.WriteLine("\n");

            TypeQuestion4(question4);
            Console.WriteLine("\n");

            TypeQuestion5(question5);
            Console.WriteLine("\n");

            EndProgram(exit);
        }

        const string intro = "Welcome! In this console app you will give me an integer of your choosing and I will\nperform mathematical operations on your input. Don't be shy, I like working with larger\nnumbers as well!";

        private static void TypeIntro(string intro)
        {
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }
        }

        const string question1 = "What is your first number?\n>>>: ";


        private static void TypeQuestion1(string question1)
        {
            for (int i = 0; i < question1.Length; i++)
            {
                Console.Write(question1[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }

            bool valid1 = true;

            while (valid1)
            {
                if (long.TryParse(Console.ReadLine(), out long intInput1))
                {
                    long intOutput1 = 50 * intInput1;
                    Console.Write("\n");
                    Convert.ToString(intOutput1);
                    Console.WriteLine($"Your input of {intInput1} multiplied by 50 = {intOutput1}!");
                    valid1 = false;
                }
                else
                {
                    Console.Write("Please enter a valid interger without any letters, let's try again!\n>>>: ");
                }
            }
        }

        const string question2 = "That was a great warmup, boy I love Maths! I'm ready for your second number!\n>>>: ";

        private static void TypeQuestion2(string question2)
        {
            for (int i = 0; i < question2.Length; i++)
            {
                Console.Write(question2[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }

            bool valid2 = true;

            while (valid2)
            {
                if (long.TryParse(Console.ReadLine(), out long intInput2))
                {
                    long intOutput2 = 25 + intInput2;
                    Console.Write("\n");
                    Convert.ToString(intOutput2);
                    Console.WriteLine($"Your input of {intInput2} plus 25 = {intOutput2}!");
                    valid2 = false;
                }
                else
                {
                    Console.Write("Please enter a valid interger without any letters, let's try again!\n>>>: ");
                }
            }
        }

        const string question3 = "A-m-a-z-i-n-g! It feels so good to be EXPRESSIVE. . . . . . as in expression. . .\nNevermind, your next number please?\n>>>: ";

        private static void TypeQuestion3(string question3)
        {
            for (int i = 0; i < question3.Length; i++)
            {
                Console.Write(question3[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }

            bool valid3 = true;

            while (valid3)
            {
                if (double.TryParse(Console.ReadLine(), out double intInput3))
                {
                    double intOutput3 = intInput3 / 12.5d;
                    Console.Write("\n");
                    Convert.ToString(intOutput3);
                    Console.WriteLine($"Your input of {intInput3} divided by 12.5 = {intOutput3}!");
                    valid3 = false;
                }
                else
                {
                    Console.Write("Please enter a valid interger without any letters, let's try again!\n>>>: ");
                }
            }
        }

        const string question4 = "Now that's what I'm talking about! Divide and conquer is the name of the game. . .\nAlrighty, shall we step it up and do some comparison operating?\nGive me another number and I'll compare it to see if yours\nis greater or not.\n>>>: ";

        private static void TypeQuestion4(string question4)
        {
            for (int i = 0; i < question4.Length; i++)
            {
                Console.Write(question4[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }

            bool valid4 = true;

            while (valid4)
            {
                if (double.TryParse(Console.ReadLine(), out double intInput4))
                {
                    if (intInput4 > 50)
                    {
                        Console.Write("\n");
                        Convert.ToString(intInput4);
                        Console.WriteLine($"When comparing your input of {intInput4} to 50, it is true that your number\nis greater than mine!");
                        valid4 = false;
                    }
                    else
                    {
                        Console.Write("\n");
                        Convert.ToString(intInput4);
                        Console.WriteLine($"When comparing your input of {intInput4} to 50, it is false that your number\nis greater than mine!");
                        valid4 = false;
                    }

                }
                else
                {
                    Console.Write("Please enter a valid interger without any letters, let's try again!\n>>>: ");
                }
            }
        }

        const string question5 = "Wooo Weee! All of this fun has gotten me wanting to try something to\nreally stretch out my Core muscles! All physical\nand virtual cores that is! Your next number please?\n>>>: ";

        private static void TypeQuestion5(string question5)
        {
            for (int i = 0; i < question5.Length; i++)
            {
                Console.Write(question5[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }

            bool valid5 = true;

            while (valid5)
            {
                if (double.TryParse(Console.ReadLine(), out double intInput5))
                {
                    double intOutput5 = intInput5 % 7;
                    Console.Write("\n");
                    Convert.ToString(intOutput5);
                    Console.WriteLine($"Division is so 20'teens I say! But finding your modulus is much more computationaly current!\nYour input of {intInput5} modulus 7 leaves a remainder of {intOutput5}!");
                    valid5 = false;
                }
                else
                {
                    Console.Write("Please enter a valid interger without any letters, let's try again!\n>>>: ");
                }
            }
        }

        const string exit = "That really was a ton of fun! By the way, is it ton or tonne,\noh who knows?!?! Wouldn't want to bother Google these days,\nhis head is always in the clouds! Anyways, thanks for playing\nand maybe we can do it again sometime!\n . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . . .\nOh yea, just press enter at any point to exit, See ya!";

        private static void EndProgram(string exit)
        {
            for (int i = 0; i < exit.Length; i++)
            {
                Console.Write(exit[i]);
                System.Threading.Thread.Sleep(35); // Sleep for 35 milliseconds
            }
            _ = Console.Read();
        }
    }
}
