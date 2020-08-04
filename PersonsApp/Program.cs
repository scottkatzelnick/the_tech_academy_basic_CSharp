using System;

namespace PersonsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee firstEmployee = new Employee()
            {
                FirstName = "Bill",
                LastName = "Smith",
                Id = 3
            };
            firstEmployee.SayName();

            Employee secondEmployee = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 3
            };
            secondEmployee.SayName();

            Console.WriteLine(firstEmployee != secondEmployee);
            Console.ReadLine();
        }
    }
}
