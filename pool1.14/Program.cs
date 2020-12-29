using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, palindrom = 0, aux;
            n = int.Parse(Console.ReadLine());
            aux = n;
            while (aux != 0)
            {
                palindrom = palindrom * 10 + aux % 10;
                aux = aux / 10;
            }
            if (palindrom == n)
                Console.WriteLine("numarul este palindrom");
            else
                Console.WriteLine("numarul nu este palindrom");
            Console.ReadKey();
        }
    }
}
