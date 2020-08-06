using System.Collections.Generic;

namespace LambdaFunctions
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public List<Employee> employees { get; set; }
    }
}
