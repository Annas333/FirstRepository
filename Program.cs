﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GithubActions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int sum = x + y;
            Console.WriteLine(sum); // Print the sum of x + y
            Thread.Sleep(5000);
        }
    }
}
