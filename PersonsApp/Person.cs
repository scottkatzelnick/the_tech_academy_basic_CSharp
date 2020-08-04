using System;

namespace PersonsApp
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public object Id { get; set; }

        public void SayName()
        {
            string first = FirstName;
            string last = LastName;
            Console.WriteLine($"Name: {first} {last}");
            Console.ReadLine();
        }
    }
}
