using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, j, val, ok = 0;
            n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Insertion Sort");
            Console.Write("Vectorul initial este: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            for (i = 1; i < n; i++)
            {
                val = v[i];
                ok = 0;
                for (j = i - 1; j >= 0 && ok != 1;)
                {
                    if (val < v[j])
                    {
                        v[j + 1] = v[j];
                        j--;
                        v[j + 1] = val;
                    }
                    else ok = 1;
                }
            }
            Console.Write("Vectorul sortat este: ");
            for (i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
