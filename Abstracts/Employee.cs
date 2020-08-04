using System;

namespace Abstracts
{
    internal class Employee : Person
    {
        public override void SayName()
        {
            string first = firstName;
            string last = lastName;
            Console.WriteLine($"Name: {first} {last}");
            Console.ReadLine();
        }
    }
}
