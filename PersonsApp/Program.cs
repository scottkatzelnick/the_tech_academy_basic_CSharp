namespace PersonsApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };
            employee.SayName();
        }
    }
}
