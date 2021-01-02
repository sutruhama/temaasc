using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                v[i] = i + 1;
                for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.WriteLine();
            int[] newarr = new int[n + 1];
            for (int i = 0; i < n+1; i++)
            {
                if (i < k-1)
                    newarr[i] = v[i];
                else
                    if (i == k - 1)
                    newarr[i] = e;
                else
                    newarr[i] = v[i - 1];

            }

            for (int i = 0; i < n+1; i++)
                Console.Write(newarr[i] + " ");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
