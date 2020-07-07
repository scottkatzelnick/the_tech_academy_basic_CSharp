using System;
using Microsoft.VisualBasic.CompilerServices;

namespace CarInsuranceRiskProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            RiskAssessment(intro, age, wait, dui, tickets, calculating, dots, qualify);            
        }

        const string intro = "This is a basic approval program for car insurance. It will ask you\nsome questions and return a “true” or “false” at the end as to whether\nor not you qualify for car insurance.";

        const string wait = "Please press Enter to continue . . .";

        const string age = "What is you age?\n>>>: ";

        const string dui = "Have you ever had a DUI?\n(please answer 'true' or 'false')\n>>>: ";

        const string tickets = "How many speeding tickets do you have?\n>>>: ";

        const string calculating = "Calculating";

        const string dots = ". . . . . .";

        const string qualify = "Have you qualified?";        

        private static void RiskAssessment(string intro, string age, string wait, string dui, string tickets, string calculating, string dots, string qualify)
        {
            for (int i = 0; i < intro.Length; i++)
            {
                Console.Write(intro[i]);
                System.Threading.Thread.Sleep(15);                
            }
            
            Console.Write("\n\n");

            for (int i = 0; i < wait.Length; i++)
            {
                Console.Write(wait[i]);
                System.Threading.Thread.Sleep(15);
            }
            
            Console.Read();
            Console.Write("\n\nQuestionnaire:\n\n");

            for (int i = 0; i < age.Length; i++)
            {
                Console.Write(age[i]);
                System.Threading.Thread.Sleep(15);
            }

            string ageInput = Console.ReadLine();
            bool ageQualify = Convert.ToInt32(ageInput) > 15;
            Console.Write("\n\n");

            for (int i = 0; i < dui.Length; i++)
            {
                Console.Write(dui[i]);
                System.Threading.Thread.Sleep(15);
            }
           
            string didDUI = Console.ReadLine();
            Console.Write("\n\n");

            for (int i = 0; i < tickets.Length; i++)
            {
                Console.Write(tickets[i]);
                System.Threading.Thread.Sleep(15);
            }

            string numTicket = Console.ReadLine();
            bool ticketQualify = Convert.ToInt32(numTicket) <= 3;
            Console.Write("\n\n");

            for (int i = 0; i < calculating.Length; i++)
            {
                Console.Write(calculating[i]);
                System.Threading.Thread.Sleep(15);
            }
            for (int i = 0; i < dots.Length; i++)
            {
                Console.Write(dots[i]);
                System.Threading.Thread.Sleep(400);
            }

            Console.Write("\n\n");

            for (int i = 0; i < qualify.Length; i++)
            {
                Console.Write(qualify[i]);
                System.Threading.Thread.Sleep(40);
            }

            Console.Write("\n\n");

            if (ageQualify == true && ticketQualify == true && didDUI != "true")
            {
                bool qualified = true;
                Console.Write(qualified);
            }
            else
            {
                Console.Write("False");
            }
        }
    }
}
