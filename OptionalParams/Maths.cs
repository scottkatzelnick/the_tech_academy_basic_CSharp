using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParams
{
    internal class Maths
    {
        // Method of class Maths
        internal static int DoubleInOneOut(string paramOne, string paramTwo = null)
        {
            long result = 0;
            if (paramTwo != null)
            {
                // Convert user input(s) to int to preform math operations on
                decimal numOne = Convert.ToDecimal(paramOne);
                decimal numTwo = Convert.ToDecimal(paramTwo);

                result = Convert.ToInt64((numOne + numTwo) / numOne * ((numOne + numTwo) / numTwo));
            }
            else
            {
                decimal numOne = Convert.ToDecimal(paramOne); // Convert user input(s) to int to preform math operations on
                result = Convert.ToInt64((numOne + numOne + numOne * numOne / numOne - numOne) * numOne);
            }

            return (int)(result);
        }
    }
}
