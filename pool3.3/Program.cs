using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int max = -1;
            int min =99999999;
            int pmin = 0; 
            int pmax = 0;
            for (int i = 0; i < n; i++)
                 v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                if (v[i] < min)
                {
                    min = v[i];
                    pmin = i;
                }
                if (v[i] > max)
                {
                    max = v[i];
                    pmax = i;
                }
            }
            Console.WriteLine("pozitia numarul maxim este" + " " + pmax);
            Console.WriteLine("pozitia numarul min este" + " " + pmin);
            Console.ReadKey();
        }
    }
}
