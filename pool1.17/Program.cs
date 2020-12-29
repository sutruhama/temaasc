using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            int c = a * b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int r = a % b;
                a = b;
                b = r;
            }
            Console.WriteLine("cel mai mare divizor comun este" + " " + a);
            Console.WriteLine("cel mai mic multiplu comun este" + " " + c / a);
            Console.ReadKey();
        }
    }
}
