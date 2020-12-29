using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, d;
            n = int.Parse(Console.ReadLine());
            for (d = 1; d <= n; d++)
            {
                if (n % d == 0)
                    Console.Write(d + " ");
            }
            Console.ReadKey();
        }
    }
}
