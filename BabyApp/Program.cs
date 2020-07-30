using System;
using System.Collections.Generic;

namespace BabyApp
{
    public static class Program
    {
        private static void Main()
        {
            // **** Baby Name ****

            bool babyValid = true;

            while (babyValid)
            {
                // Picking gender to qualify which array to sort from.
                Console.Write(
                    "Please pick if you'd like boy or girl names\n(type 'boy' or type 'girl')\n>>>: ");

                string genderChoice = Console.ReadLine();
                Console.WriteLine("\n");

                //  Choosing index to randomly select name
                Console.Write("Please pick a number from 0 through 12\n>>>: ");

                int numChoice = Convert.ToInt32(Console.ReadLine());

                // Girl names
                string[] girlNameStrings =
                {
                    "Bethany", "Nicole", "Olivia", "Tori", "Natalie", "Amber", "Skyler",
                    "Brittany", "Jessica", "Autumn", "Harper", "Samantha", "Summer"
                };
                // Boy Names
                string[] boyNameStrings =
                {
                    "Brett", "Jason", "Michael", "Glenn", "Toby", "Christopher", "Austin",
                    "Scott", "Paul", "Daniel", "Marc", "Erik", "John"
                };

                if (genderChoice == "boy")
                {
                    if (numChoice <= 12)
                    {
                        Console.WriteLine(
                            $"The baby boy's name is {boyNameStrings[numChoice]}. Congrats!");

                        bool middleValid = true;

                        do
                        {
                            Console.Write(
                                "Let's pick a number from 0 through 6 to pick the baby's middle name!\n>>>: ");

                            int middleNameInt = Convert.ToInt32(Console.ReadLine());

                            // Boy  names
                            // ReSharper disable once SuggestVarOrType_Elsewhere
                            List<string> boyMiddleNameStrings = new List<string>
                            {
                                "Fredrick",
                                "Samuel",
                                "Jessie",
                                "Anthony",
                                "Oscar",
                                "Clifford",
                                "Vincent"
                            };

                            if (middleNameInt <= 6)
                            {
                                    Console.WriteLine(
                                        $"The baby's middle name is {boyMiddleNameStrings[middleNameInt]}!");
                                    middleValid = false;
                                    babyValid = false;
                            }
                            else
                            {
                                Console.WriteLine("Please pick a number 0 through 6 only!");
                                Console.WriteLine("\n");
                            }

                        } while (middleValid);
                    }
                    else
                    {
                        Console.WriteLine(
                            "Please pick a gender as 'boy' or 'girl' and a number 0 through 12 only!");
                        Console.WriteLine("\n");
                    }

                }
                else
                {
                    if (genderChoice == "girl")
                    {
                        if (numChoice <= 12)
                        {
                            Console.WriteLine(
                                $"The baby girl's name is {girlNameStrings[numChoice]}. Congrats!");

                            bool middleValid = true;

                            do
                            {
                                Console.Write(
                                    "Let's pick a number from 0 through 6 to pick the baby's middle name!\n>>>: ");

                                int middleNameInt = Convert.ToInt32(Console.ReadLine());

                                // Girl names
                                // ReSharper disable once SuggestVarOrType_Elsewhere
                                List<string> girlMiddleNameStrings = new List<string>
                                {
                                    "Lisa",
                                    "Vanessa",
                                    "Lynn",
                                    "Elizabeth",
                                    "Paige",
                                    "Sabrina",
                                    "Leslie"
                                };

                                if (middleNameInt <= 6)
                                {
                                    Console.WriteLine(
                                        $"The baby's middle name is {girlMiddleNameStrings[middleNameInt]}!");
                                    middleValid = false;
                                    babyValid = false;
                                }
                                else
                                {
                                    Console.WriteLine("Please pick a number 0 through 6 only!");
                                    Console.WriteLine("\n");
                                }

                            } while (middleValid);
                        }
                        else
                        {
                            Console.WriteLine(
                                "Please pick a gender as 'boy' or 'girl' and a number 0 through 12 only!");
                            Console.WriteLine("\n");
                        }

                    }
                    else
                    {
                        Console.WriteLine(
                            "Please pick a gender as 'boy' or 'girl' and a number 0 through 12 only!");
                        Console.WriteLine("\n");
                    }
                }
            }

            // ================================================================================================

            // Picking the baby's luck number
            bool luckyValid = true;

            // Logic to pick lucky number with index error prevention
            do
            {
                Console.Write(
                    "Lets pick a lucky number for the baby! Please pick a number from 0 - 12\n>>>: ");

                // Array with randomly placed numbers to make choice more dynamic
                int[] luckyNumChooser = {8, 12, 9, 1, 5, 6, 11, 2, 4, 10, 7, 0, 3};

                int luckyNumChoice = Convert.ToInt32(Console.ReadLine());

                // Displaying lucky number based on the choice
                if (luckyNumChoice <= 12)
                {
                    Console.WriteLine(
                        $"The baby's lucky number is {luckyNumChooser[luckyNumChoice]}!");
                    luckyValid = false;
                }
                else
                {
                    Console.WriteLine("Please pick a number 0 through 12 only!");
                    Console.WriteLine("\n");
                }
            } while (luckyValid);

            // ===============================================================================================

            Console.WriteLine("Enter To Exit . . . . . ");
            Console.Read();
        }
    }
}
