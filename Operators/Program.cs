﻿using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            Console.WriteLine(!(x > 3 && x < 10)); // returns False because ! (not) is used to reverse the result
        }
    }
}
