using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._1
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b, x;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("Exista o infinitate de solutii");
                else
                    Console.WriteLine("Ecuatie imposibila");
            else
            {
                x = -b / a;
                Console.WriteLine("Solutia ecuatiei este " + " " + x);
            }
            Console.ReadKey();
        }
    }
}
