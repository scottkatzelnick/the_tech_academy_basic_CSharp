using System;

namespace DoubleDown
{
    // Static class
    internal static class Fixed
    {
        // Static method with out parameter slightly different to differentiate overloaded method
        public static void Double(int num, out string newNum)
        {
            newNum = Convert.ToString(num / 2);
        }
    }
}
