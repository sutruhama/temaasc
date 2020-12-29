using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if ((a < b + c) && (b < a + c) && (c < a + b))
                Console.WriteLine("pot fi lungimile laturilor unui triunghi");
            else
                Console.WriteLine("nu pot fi lungimile laturilor unui triunghi");
            Console.ReadKey();
        }
    }
}
