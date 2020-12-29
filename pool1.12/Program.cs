using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a, b, c = 0; ;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                if (i % n == 0)
                    c++;

            }
            Console.Write(c);
            Console.ReadKey();
        }
    }
}
