using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._10
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
            int pos = Array.BinarySearch(v, k);
            if (pos >= 0)
                Console.WriteLine($"Item {v[pos].ToString()} found at position {pos + 1}.");
            else
                Console.WriteLine(-1);
            Console.ReadKey();

        }
    }
}
