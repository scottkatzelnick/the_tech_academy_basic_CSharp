using System;
using System.Collections.Generic;

namespace Iterations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testScores = {98, 99, 95, 85, 73, 60, 77, 91, 84, 50, 87, 69, 61};

            // Iterate an integer array using a for loop
            for (int i = 0; i < testScores.Length; i++)
            {
                if (testScores[i] >= 85)
                {
                    Console.WriteLine("Passing test score: " + testScores[i]);
                }
            }

            // Iterate a string array
            string[] names = {"Jesse", "Erik", "Daniel", "Adam"};

            for (int j = 0; j < names.Length; j++)
            {
                if (names[j] == "Jesse")
                {
                    Console.WriteLine(names[j]);
                }
            }

            for (int j = 0; j < names.Length; j++)
            {
               Console.WriteLine(names[j]); 
            }

            List<int> testScoresList = new List<int>
            {
                98, 99, 95, 81, 78, 60, 89, 91, 89, 50, 87, 69, 61
            };

            foreach (int score in testScoresList)
            {
                if (score > 85)
                {
                    Console.WriteLine("Passing test score: " + score);
                }
            }

            List<string> namesList = new List<string>()
            {
                "Jesse", "Erik", "Daniel", "Adam"
            };

            foreach (string name in namesList)
            {
                if (name == "Jesse")
                {
                    Console.WriteLine(name);
                }
            }

            foreach (string name in namesList)
            {
                Console.WriteLine(name);
            }

            List<int> testScores2 = new List<int>()
            {
                98, 99, 12, 74, 23, 99
            };

            List<int> passingScores = new List<int>();

            foreach (int score in testScores2)
            {
                if (score > 85)
                {
                    passingScores.Add(score);
                }
            }

            Console.WriteLine(passingScores.Count);



            Console.Read();
        }
    }
}
