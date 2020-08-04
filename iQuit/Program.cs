using Abstracts;

namespace iQuit
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Person person = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };
            person.SayName();

            IQuittable student = new Employee();
            student.Quit();
        }
    }
}
