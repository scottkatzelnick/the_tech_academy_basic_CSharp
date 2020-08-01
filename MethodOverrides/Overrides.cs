using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverrides
{
    internal class Overrides
    {
        public int SelfOperate(int input)
        {
            int two = (input + input) / input;
            return two;
        }

        public int SelfOperate(float decInput)
        {
            int stripped = Convert.ToInt32(decInput * decInput);
            return stripped;
        }

        public int SelfOperate(string strInput)
        {
            int evenOdd = 0;
            try
            {
                int strInt = Convert.ToInt32(strInput);
                evenOdd = strInt % 2;
                return evenOdd;
            }
            catch (FormatException err)
            {
                Console.WriteLine("Error: {0}", err.Message);
                evenOdd = 2;
                return evenOdd;
            }
        }
    }
}
