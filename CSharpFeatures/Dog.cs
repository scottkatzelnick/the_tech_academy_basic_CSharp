﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatures
{
    public class Dog
    {
        public Dog(string name) : this(name, 1) // Class Chain Propagation
        {
        }

        public Dog(string name, int age) // Original Class
        {
            Console.WriteLine($"This Golden Retriever's name is going to be {name}! They are {age} year(s) old");
        }
    }
}
