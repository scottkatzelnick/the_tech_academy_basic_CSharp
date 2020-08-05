using System;
using System.Collections.Generic;

namespace PersonsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee<Person> firstEmployee = new Employee<Person>()
            {
                FirstName = "Bill",
                LastName = "Smith",
                Id = 2
            };
            firstEmployee.SayName();

            Employee<Person> secondEmployee = new Employee<Person>()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 3
            };
            secondEmployee.SayName();

            Console.WriteLine(firstEmployee == secondEmployee);
            Console.ReadLine();

            Employee<string> employeeBenefit = new Employee<string>();
            employeeBenefit.Things = new List<string>()
            {
                "Personals",
                "Vacation Days",
                "Sick Time"
            };

            Employee<int> benefitAmount = new Employee<int>();
            benefitAmount.Things = new List<int>()
            {
                5,
                10,
                8
            };

            foreach (string benefit in employeeBenefit.Things)
            {
                Console.WriteLine($"My benefit is {benefit} and I have {benefitAmount.Things[employeeBenefit.Things.IndexOf(benefit)]} days remaining!");
            }
            Console.ReadLine();
        }
    }
}
