using System;

namespace OptionalParams
{
    public class Maths
    {
        // Method of class Maths
        internal int DoubleInOneOut(string paramOne, string paramTwo = null)
        {
            // Convert user input(s) to int to preform math operations on
            decimal numOne = Convert.ToDecimal(paramOne);
            long result;
            switch (paramTwo)
            {
                case null:
                    result = Convert.ToInt64((numOne + numOne + numOne * numOne / numOne - numOne) * numOne);
                    break;

                default:
                    {
                        decimal numTwo = Convert.ToDecimal(paramTwo);
                        result = Convert.ToInt64((numOne + numTwo) / numOne * ((numOne + numTwo) / numTwo));
                        break;
                    }
            }

            return (int)(result);
        }
    }
}
