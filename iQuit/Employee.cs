using iQuit;
using System;

namespace Abstracts
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            string first = firstName;
            string last = lastName;
            Console.WriteLine($"My name is {first} {last} and . . . ");
            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("I Quit! I'm off to become a Software Developer!");
            Console.ReadLine();
        }
    }
}
