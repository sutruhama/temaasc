using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a;  bool ok=false;
            n = int.Parse(Console.ReadLine());
            a = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == a)
                {
                    ok = true;
                    Console.WriteLine("pozitia este" + " " + i);
                }
            }
            if (ok == false)
                Console.WriteLine(-1);
            Console.ReadKey();
        }
    }
}
