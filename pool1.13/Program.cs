﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int y1, y2, c = 0;
            y1 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            for (int i = y1; i <= y2; i++)
            {
                if ((i % 4 == 0) && (i % 100 != 0))
                    c++;
                else
                if (i % 400 == 0)
                    c++;
            }
            Console.Write(c);
            Console.ReadKey();
        }
    }
}
