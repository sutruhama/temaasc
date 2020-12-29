using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x, max = -1, min=999999;
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x > max)
                    max = x;
                else
                    if (x < min)
                    min = x;
            }
            Console.WriteLine("maximul este" + " " + max);
            Console.WriteLine("minimul este" + " " + min);
            Console.ReadKey();
        }
    }
}
