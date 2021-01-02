using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int ok = 0;
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int k = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                if (v[i] == k)
                {
                    ok = 1;
                    Console.WriteLine("pozitia este" + " " + i);
                    break;
                }
            if (ok == 0)
                Console.WriteLine(-1);
            Console.ReadKey();

        }
    }
}
