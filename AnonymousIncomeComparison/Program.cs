using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            string person1 = "Person 1";
            Console.WriteLine(person1);
            decimal hourlyRate = 21.5m;
            Console.WriteLine($"Hourly Rate?\n{hourlyRate}");
            int hoursWorked = 40;
            Console.WriteLine($"Hours worked per week?\n{hoursWorked}");
            string person2 = "Person 2";
            Console.WriteLine(person2);
            decimal hourlyRate2 = 19.77m;
            Console.WriteLine($"Hourly Rate?\n{hourlyRate2}");
            int hoursWorked2 = 50;
            Console.WriteLine($"Hours worked per week?\n{hoursWorked2}");
            decimal annualPerson1 = (hoursWorked * hourlyRate) * 52;
            Console.WriteLine($"Annual salary of Person 1:\n{annualPerson1}");
            decimal annualPerson2 = (hoursWorked2 * hourlyRate2) * 52;
            Console.WriteLine($"Annual salary of Person 2:\n{annualPerson2}");
            bool comparePerson1 = annualPerson1 > annualPerson2;
            Console.WriteLine($"Does Person 1 make more money than Person 2?\n{comparePerson1}");
        }
    }
}
