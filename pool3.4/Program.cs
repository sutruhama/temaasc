using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int apmin = 0;
            int apmax = 0;
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (v[i] == v.Min())
                    apmin++;
                if (v[i] == v.Max())
                    apmax++;
            }
                Console.WriteLine("Minimul este"+" "+v.Min()+" "+apmin);
                Console.WriteLine("Maximul este"+" "+v.Max()+" "+apmax);
            
            Console.ReadKey();

        }
    }
}
