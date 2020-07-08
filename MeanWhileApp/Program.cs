using System;

namespace MeanWhileApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type 'upper' or 'lower' to display respective result\n>>>: ");
            string caseChoice = Console.ReadLine();
            bool valid = true;

            while (valid)
            {
                Console.Write("Please only type 'upper' or 'lower'!\n>>>: ");
                string caseChoiceAlt = Console.ReadLine();

                if (caseChoice == "upper" || caseChoiceAlt == "upper")
                {
                    Console.Write("\n\n");
                    MeanWhileUpper(alphabetUpper);
                    valid = false;
                }
                else if (caseChoice == "lower" || caseChoiceAlt == "lower")
                {
                    Console.Write("\n\n");
                    MeanWhileLower(alphabetLower);
                    valid = false;
                }
                else
                {
                    valid = true;
                }
            }
            
            Console.Write("\n\n");

            Console.Write("Please type 'digits' or 'characters' to display their respective results\n>>>: ");
            string caseChoice_2 = Console.ReadLine();
            bool validAgain;

            do
            {
                Console.Write("Please only type 'digits' or 'characters'!\n>>>: ");
                string caseChoiceAlt_2 = Console.ReadLine();

                if (caseChoice_2 == "digits" || caseChoiceAlt_2 == "digits")
                {
                    Console.Write("\n\n");
                    MeanWhileDigits(digits);
                    validAgain = false;
                }
                else if (caseChoice_2 == "characters" || caseChoiceAlt_2 == "characters")
                {
                    Console.Write("\n\n");
                    MeanWhileCharacters(specialChar);
                    validAgain = false;
                }
                else
                {
                    validAgain = true;
                }
            } while (validAgain);

            Console.Write("\n\n");
            Console.WriteLine("You made it! Congrats!");
            Console.Write("Enter to Quit . . . . . . . . . . . ;)");
            Console.Read();

        }

        const string alphabetLower = "a b c d e f g h i j k l m n o p q r s t u v w x y z";
        const string alphabetUpper = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z";
        const string digits = "0 1 2 3 4 5 6 7 8 9";
        const string specialChar = "! @ # $ % ^ & * ( ) - + _ = [ ] { } \\ | ; : ' \" < , > . / ? ` ~";

        static void MeanWhileUpper(string alphabetUpper)
        {
            for (int i = 0; i < alphabetUpper.Length; i++)
            {
                Console.Write(alphabetUpper[i]);
                System.Threading.Thread.Sleep(40);
            }
        }

        static void MeanWhileLower(string alphabetLower)
        {
            for (int i = 0; i < alphabetLower.Length; i++)
            {
                Console.Write(alphabetLower[i]);
                System.Threading.Thread.Sleep(40);
            }
        }
        static void MeanWhileDigits(string digits)
        {
            for (int i = 0; i < digits.Length; i++)
            {
                Console.Write(digits[i]);
                System.Threading.Thread.Sleep(40);
            }
        }

        static void MeanWhileCharacters(string specialChar)
        {
            for (int i = 0; i < specialChar.Length; i++)
            {
                Console.Write(specialChar[i]);
                System.Threading.Thread.Sleep(40);
            }
        }
    }
}
