﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, c;
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                c = n % 10;
                n = n / 10;
                Console.Write(c + " ");
            }
            Console.ReadKey();
        }
    }
}
