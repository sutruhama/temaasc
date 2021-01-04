﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pool3._17
{
    class Program
    {
        static void Main(string[] args)
        {
          
            int num, baseNum;
            Console.Write("Enter a decimal number: ");
            num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            Console.Write(num + " converts to ");
            MulBase(num, baseNum);
            Console.WriteLine(" Base " + baseNum);
            Console.Read();
        }
        static void MulBase(int n, int b)
        {
            Stack Digits = new Stack();
            do
            {
                Digits.Push(n % b);
                n /= b;
            } while (n != 0);
            while (Digits.Count > 0)
                Console.Write(Digits.Pop());
        }
    }
}
