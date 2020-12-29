using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._8
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a=" + a + " " + "b=" + b);
            Console.ReadKey();
        }
    }
}
