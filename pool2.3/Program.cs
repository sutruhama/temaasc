using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,p=1;
            n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
                p = p * i;
            Console.WriteLine("Produsul este"+" "+p);
            Console.ReadKey();
        }
    }
}
