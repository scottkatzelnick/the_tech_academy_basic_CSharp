using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const string goldenRetrieverBreeder = "Green Leaf Farms"; // Const variable type

            Console.Write("Please enter in your desired dog's name\n>>>: ");
            var dogName = Console.ReadLine(); // Var type declaration

            Console.WriteLine($"{goldenRetrieverBreeder}:\n");
            Dog dog = new Dog(dogName); // Calling the class chain constructor
            Console.ReadLine();
        }
    }
}
