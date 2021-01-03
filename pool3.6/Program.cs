using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = k; i < n-1; i++)
                v[i] = v[i + 1];
            Array.Resize(ref v, n - 1);
            for (int i = 0; i < n - 1; i++)
                Console.WriteLine(v[i] + " ");
                Console.ReadKey();
        }
    }
}
