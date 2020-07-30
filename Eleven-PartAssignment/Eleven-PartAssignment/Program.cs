using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Eleven_PartAssignment
{
    public static class Program
    {
        [SuppressMessage("ReSharper", "InvertIf")]
        private static void Main()
        {
            // Assignment 1 - Have user add onto end of strings in array and print to console
            string[] newArray = { "8UYGUU98uj", "7tfgyuv", "8vuy786&gg", "jh76FDS5%7" };

            Console.Write(
                "Please enter a random set of numbers, letters and/or\nspecial character to create a unique password.\n>>>: ");

            string randomPassword = Console.ReadLine();

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] += randomPassword;
            }

            Console.WriteLine(
                "\nTo see your choice of unique passwords please press enter . . . . .");

            Console.ReadLine();

            foreach (string password in newArray)
            {
                Console.WriteLine(password);
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignments 2 - Infinite Loop
            bool valid = true;
            while (valid)
            {
                for (int j = 0; j >= 0; j++)
                {
                    // Assignments 3 - Fix for infinite loop from assignment 2
                    if (j == 101)
                    {
                        valid = false;
                        break;
                    }

                    Console.WriteLine(j);
                }
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignment 4 - Create loop using "<" operator (Fibonacci Sequence up to 20 terms)
            Console.WriteLine("The Fibonacci Sequence up to the 20th term!");
            int t1 = 0, t2 = 1;
            for (int x = 0; x < 20; x++)
            {
                int nextTerm = t1 + t2;
                t1 = t2;
                t2 = nextTerm;

                Console.WriteLine(t1);
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignment 5 - Create loop using "<" operator (Fibonacci Sequence up to and including
            // the 20th term)
            Console.WriteLine("The Fibonacci Sequence up to and including the 20th term!");
            int f1 = 0, f2 = 1;
            for (int x = 0; x <= 20; x++)
            {
                int nextTerm = f1 + f2;
                f1 = f2;
                f2 = nextTerm;

                Console.WriteLine(f1);
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignment 6 - Search in list and output index of matching strings
            List<string> animalList = new List<string>
            {
                "dog",
                "cat",
                "elephant",
                "frog",
                "bear",
                "wolf",
                "turtle",
                "monkey",
                "whale",
                "bird",
                "spider",
                "human",
                "snake"
            };

            Console.Write(
                "Please type out a popular animal, i.e. \"monkey\" to display if it's in the list\n>>>: ");

            string userAnimal = Console.ReadLine();
            string lower = userAnimal?.ToLower();
            bool didNotFind = true;

            Console.Write("\n");

            foreach (string animal in animalList)
            {
                if (lower == animal)
                {
                    Console.WriteLine(
                        $"The index of your matching animal is {animalList.IndexOf(animal)}!");
                    didNotFind =
                        false; // --> For Assignment 7 - Message if user input from assignment 6 doesn't match any items in the list.
                    // Assignment 8 - Stops the foreach loop once match is found.
                    break;
                }
            }

            if (didNotFind)
            {
                Console.WriteLine(
                    "Sorry, that animal is not in the list. Better luck next time."); // --> (assignment 7 message)
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignment 9 - List with matching pairs
            List<string> moneyList = new List<string>()
            {
                "$100 bill",
                "penny",
                "$10 bill",
                "dime",
                "$100 bill",
                "silver dollar",
                "$10 bill",
                "quarter",
                "$5 bill",
                "quarter",
                "silver dollar",
                "nickel",
                "$50 bill",
                "penny",
                "$20 bill",
                "$50 bill",
                "nickel",
                "$1 bill",
                "$5 bill",
                "$20 bill",
                "dime",
                "$1 bill"
            };

            Console.Write("Please type your choice from the following list:\n");
            for (int j = 0; j < moneyList.Count; j++)
            {
                Console.WriteLine(moneyList[j]);
            }
            Console.Write("\n>>>: ");

            string userMoney = Console.ReadLine();
            string userMoneyLower = userMoney?.ToLower();

            var indices = new List<int>();

            bool isNotInList = true;

            for (int i = 0; i < moneyList.Count; i++)
            {
                if (userMoneyLower == moneyList[i])
                {
                    indices.Add(i);
                }
            }

            Console.WriteLine("\nThe indices for the choosen denomination are:");
            if (indices.Count != 0)
            {
                foreach (int ind in indices)
                {
                    Console.WriteLine(ind);
                }

                isNotInList = false;
            }

            // Assignment 10 - Message is not in list
            if (isNotInList)
            {
                Console.WriteLine("Sorry, your choice isn't in the List. Maybe try again later?");
            }

            Console.WriteLine("\nEnter to Continue . . .");
            Console.ReadLine();

            // Assignment 11 - Print items in List and if they've been printed previously from the
            // same List or not
            List<string> newList = new List<string>
            {
                "C#",
                "JavaScript",
                "Python",
                "C#",
                "php",
                "HTML",
                "Python"
            };

            var numberMap = new Dictionary<string, bool>();

            Console.WriteLine("List Elements:");
            foreach (string text in newList)
            {
                if (!numberMap.ContainsKey(text))
                {
                    numberMap.Add(text, true);
                    Console.WriteLine(
                        $"{text} - First time seen in list.");
                }
                else
                {
                    Console.WriteLine(
                        $"{text} - Already in list.");
                }
            }

            Console.WriteLine("\n");
            Console.WriteLine("Enter to Exit . . . . .");
            Console.ReadLine();
        }
    }
}
