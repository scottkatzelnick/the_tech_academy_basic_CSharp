using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaFunctions
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Instantiate employee list
            List<Employee> employees = new List<Employee>();

            // Add employees to list
            Employee employee1 = new Employee();
            employee1.FirstName = "Joe";
            employee1.LastName = "Smith";
            employee1.Id = 01;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.FirstName = "Howard";
            employee2.LastName = "Kennedy";
            employee2.Id = 02;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.FirstName = "Scott";
            employee3.LastName = "Katz";
            employee3.Id = 03;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.FirstName = "Melissa";
            employee4.LastName = "Cummins";
            employee4.Id = 04;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.FirstName = "Derick";
            employee5.LastName = "Vosdrunick";
            employee5.Id = 05;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.FirstName = "Rachael";
            employee6.LastName = "Yersin";
            employee6.Id = 06;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.FirstName = "Lannie";
            employee7.LastName = "Cadence";
            employee7.Id = 07;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.FirstName = "Joe";
            employee8.LastName = "Booth";
            employee8.Id = 08;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.FirstName = "Oliver";
            employee9.LastName = "Yoo";
            employee9.Id = 09;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.FirstName = "Toby";
            employee10.LastName = "Shea";
            employee10.Id = 10;
            employees.Add(employee10);

            // Create list to keep filtered results // List<Employee> filteredList = new List<Employee>();

            // Foreach loop to filter FirstName == "Joe"
            //foreach (Employee employee in employees)
            //{
            //    if (employee.FirstName == "Joe")
            //    {
            //        filteredList.Add(employee);
            //        Console.WriteLine(employee.FirstName + " " + employee.LastName);
            //    }
            //}
            //Console.ReadLine();

            // Lambda expression to filter FirstName == "Joe"
            List<Employee> filteredList = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in filteredList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.ReadLine();

            // Lambda expression to filter Id > 5
            List<Employee> filteredList2 = employees.Where(x => x.Id > 5).ToList();

            foreach (Employee employee in filteredList2)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} has an Id of {employee.Id}!");
            }
            Console.ReadLine();
        }
    }
}
