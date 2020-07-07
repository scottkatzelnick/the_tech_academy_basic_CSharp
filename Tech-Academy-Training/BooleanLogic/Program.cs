using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            // AND Operator - True if both are true
            Console.WriteLine(true && false);
            Console.WriteLine(true && true);
            Console.WriteLine(false && false);
            Console.WriteLine("\n");

            // OR Operator - True if either one is true
            Console.WriteLine(true || false);
            Console.WriteLine(true || true);
            Console.WriteLine(false || false);
            Console.WriteLine("\n");

            // Equality Operator - Checks for explicitly identical values and data types
            Console.WriteLine(true == false);
            Console.WriteLine(true == true);
            Console.WriteLine(false == false);
            Console.WriteLine("\n");

            // No Equality Operator - Checks for explicit differences in values and data types
            Console.WriteLine(true != false);
            Console.WriteLine(true != true);
            Console.WriteLine(false != false);
            Console.WriteLine("\n");

            // XOR Operator - True if one is true, but not both
            Console.WriteLine(true ^ false);
            Console.WriteLine(true ^ true);
            Console.WriteLine(false ^ false);
            Console.WriteLine("\n");

            // Multiple Comparisons
            Console.WriteLine(true && false || true == false != true ^ false);
            Console.Read();
        }
    }
}
