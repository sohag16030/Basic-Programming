﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumberTheoryAlgo
{
    class Factorial
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
        }
    }
}
