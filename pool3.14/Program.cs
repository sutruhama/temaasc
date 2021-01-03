using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._14
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int contor = 0;
            for (int i = 0; i < n; i++)
            {
                if (v[i] != 0)
                {
                    v[contor] = v[i];
                    contor++;
                }
            }
            while(contor<n)
            {
                v[contor] = 0;
                contor++;
            }
            for (int i = 0; i < n; i++)
                Console.Write(v[i] + " ");
            Console.ReadKey();
        }
    }
}
