using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            if (n % k == 0)
                Console.WriteLine("Numarul" + " " + n + " " + "se divide cu " + " " + k);
            else
                Console.WriteLine("Numarul" + " " + n + " " + "nu se divide cu " + " " + k);
            Console.ReadKey();
        }

    }
}
