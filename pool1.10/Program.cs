using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; bool ok = true;
            n = int.Parse(Console.ReadLine());
            if (n < 2)
                Console.WriteLine("numarul" + " " + n + " " + "nu este prim");
            for (int d = 2; d * d <= n; d++)
            {
                if (n % d == 0)
                    ok = false;
            }
            if (ok)
                Console.WriteLine("numarul" + " " + n + " " + "este prim");
            Console.ReadKey();

        }
    }
}
