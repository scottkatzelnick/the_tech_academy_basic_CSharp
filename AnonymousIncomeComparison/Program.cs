using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            // Program Intro & Person 1 Name
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");          

            // Person 1 Hourly Rate
            Console.Write($"Hourly Rate?\n>>>: ");
            string hourlyRate = Console.ReadLine();

            // Person 1 Hours Worked
            Console.Write($"Hours worked per week?\n>>>: ");
            string hoursWorked = Console.ReadLine();

            //Person 2 Name
            Console.WriteLine("Person 2");       

            // Person 2 Hourly Rate
            Console.Write("Hourly Rate?\n>>>: ");
            string hourlyRate2 = Console.ReadLine();

            // Person 2 Hours Worked            
            Console.Write($"Hours worked per week?\n>>>: ");
            string hoursWorked2 = Console.ReadLine();

            // Person 1 Annual Salary
            decimal annualPerson1 = (Convert.ToDecimal(hoursWorked) * Convert.ToDecimal(hourlyRate)) * 52;
           
            // Person 2 Annual Salary
            decimal annualPerson2 = (Convert.ToDecimal(hoursWorked2) * Convert.ToDecimal(hourlyRate2)) * 52;
            
            // Salary Comparison
            bool comparePersons = annualPerson1 > annualPerson2;
            

            // Summary Report
            Console.WriteLine("\n\n\n\nAnonymous Income Comparison Report");
            Console.WriteLine($"Person 1\nHourly Rate:\n${hourlyRate}/hr.\nHours worked per week:\n{hoursWorked} hours");
            Console.WriteLine($"Person 2\nHourly Rate:\n${hourlyRate2}/hr.\nHours worked per week:\n{hoursWorked2} hours");
            Console.WriteLine($"Annual salary of Person 1:\n${annualPerson1}");
            Console.WriteLine($"Annual salary of Person 2:\n${annualPerson2}");
            Console.WriteLine($"Does Person 1 make more money than Person 2?\n{comparePersons}");
        }
    }
}
