using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._18
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d, p;
            n = int.Parse(Console.ReadLine());
            d = 2;
            while (n > 0)
            {
                p = 0;
                while (n % d == 0)
                {
                    p++;
                    n = n / d;
                }
                if (p > 0)
                    Console.Write(d + " " + " ^ " + " " + p + " ");
                d++;
            }
            Console.ReadKey();
        }
    }
}
