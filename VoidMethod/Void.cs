using System;

namespace VoidMethod
{
    internal class Void
    {
        // Void method Function(), of Void class
        internal void Function(int numOne, int numTwo)
        {
            // Math operation on first param
            _ = numOne ^ 2;

            // Print second param to console
            Console.WriteLine(numTwo);
            Console.ReadLine();
        }
    }
}
