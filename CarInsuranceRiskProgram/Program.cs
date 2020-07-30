using System;
using System.Threading;

// ReSharper disable InconsistentNaming
// ReSharper disable ParameterHidesMember

namespace CarInsuranceRiskProgram
{
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Program
    {
        private static void Main()
        {
            RiskAssessmentAge(intro, wait, age);

            Console.Write("\n\n");

            RiskAssessmentDui(dui);

            Console.Write("\n\n");

            RiskAssessmentTickets(tickets);

            Console.Write("\n\n");

            RiskAssessmentQualify(calculating, dots, qualify, ageQualify, didDui, tooManyTickets);

            Console.WriteLine("\n");
        }

        private const string intro =
            "This is a basic approval program for car insurance. It will ask you\nsome questions and return a “true” or “false” at the end as to whether\nor not you qualify for car insurance.";

        private const string wait = "Please press Enter to continue . . .";

        private const string age = "What is you age?\n>>>: ";

        private const string dui = "Have you ever had a DUI?\n(please answer 'true' or 'false')\n>>>: ";

        private const string tickets = "How many speeding tickets do you have?\n>>>: ";

        private const string calculating = "Calculating";

        private const string dots = ". . . . . .";

        private const string qualify = "Have you qualified?";

        private const string exit = "Enter to exit . . . . . . ";

        private static bool ageQualify;

        private static void RiskAssessmentAge(string intro, string wait, string age)
        {
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                Thread.Sleep(15);
            }

            Console.Write("\n\n");

            for (int i = 0; i < wait.Length; i++)
            {
                Console.Write(wait[i]);
                Thread.Sleep(15);
            }

            Console.ReadLine();
            Console.Write("\n\nQuestionnaire:\n\n");

            bool ageValid = true;
            while (ageValid)
            {
                for (int i = 0; i < age.Length; i++)
                {
                    Console.Write(age[i]);
                    Thread.Sleep(15);
                }

                if (int.TryParse(Console.ReadLine(), out int ageInput))
                {
                    ageQualify = ageInput > 15;
                    ageValid = false;
                }
                else
                {
                    Console.Write("Please give your age as a number only! Let's try again. ");
                }
            }
        }

        private static bool didDui;

        private static void RiskAssessmentDui(string dui)
        {
            bool validDui = true;
            while (validDui)
            {
                for (int i = 0; i < dui.Length; i++)
                {
                    Console.Write(dui[i]);
                    Thread.Sleep(15);
                }

                string duiInput = Console.ReadLine();

                switch (duiInput)
                {
                    case "true":
                        didDui = true;
                        validDui = false;
                        break;

                    case "false":
                        didDui = false;
                        validDui = false;
                        break;

                    default:
                        Console.WriteLine("Please only type 'true' or false' as an acceptable answer! ");
                        Console.WriteLine("\n");
                        break;
                }
            }
        }

        private static bool tooManyTickets;

        private static void RiskAssessmentTickets(string tickets)
        {
            bool validTickets = true;
            while (validTickets)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    Console.Write(tickets[i]);
                    Thread.Sleep(15);
                }

                if (int.TryParse(Console.ReadLine(), out int numTickets))
                {
                    tooManyTickets = numTickets <= 3;
                    validTickets = false;
                }
                else
                {
                    Console.WriteLine("Please give your ticket count as a number only! Let's try again. ");
                }
            }
        }

        private static void RiskAssessmentQualify(string calculating, string dots, string qualify,
            bool ageQualify, bool didDui, bool tooManyTickets)
        {
            for (int i = 0; i < calculating.Length; i++)
            {
                Console.Write(calculating[i]);
                Thread.Sleep(15);
            }

            for (int i = 0; i < dots.Length; i++)
            {
                Console.Write(dots[i]);
                Thread.Sleep(400);
            }

            Console.Write("\n\n");

            for (int i = 0; i < qualify.Length; i++)
            {
                Console.Write(qualify[i]);
                Thread.Sleep(40);
            }

            Console.Write("\n\n");

            if (ageQualify && tooManyTickets)
            {
                switch (didDui)
                {
                    case false:
                        Console.WriteLine(true);
                        break;

                    default:
                        Console.WriteLine(false);
                        break;
                }
            }
            else
            {
                Console.WriteLine(false);
            }

            Console.Write("\n\n");

            for (int i = 0; i < exit.Length; i++)
            {
                Console.Write(exit[i]);
                Thread.Sleep(40);
            }

            Console.Read();
        }
    }
}
