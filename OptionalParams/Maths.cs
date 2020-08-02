using System;

namespace OptionalParams
{
    public class Maths
    {
        // Method of class Maths, takes in one, or two inputs and outputs an integer result
        internal int DoubleInOneOut(string paramOne, string paramTwo = null) // Setting paramTwo to null instanciates it as optional
        {
            // Convert required user input to decimal to preform math operations on
            decimal numOne = Convert.ToDecimal(paramOne);
            long result; // Initialize result variable as long, to accomodate larger numbers

            // Switch statement based on value of optional parameter
            switch (paramTwo)
            {
                // If null, only needs first input
                case null:
                    result = Convert.ToInt64((numOne + numOne * numOne) / (numOne * numOne - numOne));
                    break;

                // Otherwise, by default will use both inputs
                default:
                    decimal numTwo = Convert.ToDecimal(paramTwo);
                    result = Convert.ToInt64((numOne + numTwo) / numOne * ((numOne + numTwo) / numTwo));
                    break;
            }

            // Returns either result as int
            return (int)(result);
        }
    }
}
