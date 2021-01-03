using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Selection sort");
            Console.Write("Vectorul initial este: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            int temp, min;
            for (int i = 0; i < n - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (v[j] < v[min])
                    {
                        min = j;
                    }
                }
                temp = v[min];
                v[min] = v[i];
                v[i] = temp;
            }
            Console.WriteLine();
            Console.Write("Vectorul sortat este: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(v[i] + " ");
            }
            Console.ReadKey();
        }
    }
}
