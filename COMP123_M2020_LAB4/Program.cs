﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_M2020_LAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            Person jaskirat = new Person("Jaskirat", age: 20);

            jaskirat.SaysHello();

            Console.ReadLine();
        }
    }
}
