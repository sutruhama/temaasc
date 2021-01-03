using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] v = new bool[n];

            for (int i = 2; i < n; i++)
            {
                v[i] = true;
            }

            for (int j = 2; j * j <= n; j++)
            {
                if (v[j] == true)
                {
                    for (int k = j * j; k < n; k += j)
                    {
                        v[k] = false;
                    }
                }
            }
            for(int i=0;i<n;i++)
            {
                if(v[i]==true)
                    Console.Write($"{i} ");
            }
            Console.ReadKey();

        }
    }
}
