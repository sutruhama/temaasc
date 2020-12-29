using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            if (a <= b && b <= c)
                Console.WriteLine(a + " " + " " + b + " " + c);
            if (b <= a && a <= c)
                Console.WriteLine(b + " " + a + " " + c + " ");
            if (c <= a && a <= b)
                Console.WriteLine(c + " " + a + " " + b + " ");
            if (c <= b && b <= a)
                Console.WriteLine(c + " " + b + " " + a + " ");
            if (b <= c && c <= a)
                Console.WriteLine(b + " " + c + " " + a + " ");
            if (a <= c && c <= b)
                Console.WriteLine(a + " " + c + " " + b + " ");
            Console.ReadKey();
        }
    }
}
