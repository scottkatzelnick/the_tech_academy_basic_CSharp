using System;
using System.Collections.Generic;

    class Program
    {
        static void Main()
        {

            List<string> strList = new List<string>();
            strList.Add("Hello");
            strList.Add("Goodbye");
            strList.Add("Jessie");
            strList.Remove("Jessie");

            foreach (var str in strList)
            {
                Console.WriteLine(str);
            }

            List<int> intList = new List<int>();
            intList.Add(10);
            intList.Add(5);
            intList.Add(2);
            intList.Remove(2);

            foreach (int n in intList )
            {
                Console.WriteLine(n);
            }

            int[] numArray = new int[5];

            numArray[0] = 5;
            numArray[1] = 2;
            numArray[2] = 10;
            numArray[3] = 200;
            numArray[4] = 5000;

            // Alternative way to initialise an array
            int[] numArray1 = new int[] {5, 2, 10, 200, 5000, 600, 2300};

            // Super quick way to initialize an array
            int[] numArray2 = {5, 2, 10, 200, 5000, 600, 2300};

            // Easily change value for an index
            numArray2[5] = 650;

            Console.WriteLine(numArray[3]);
            Console.WriteLine(numArray1[3]);
            Console.WriteLine(numArray2[3]);
            Console.WriteLine(numArray2[5]);
            Console.Read();
        }
    }

