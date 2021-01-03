using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("\nArray1: [{0}]", string.Join(", ", v));
            var temp = v[0];
            for (var i = 0; i < n - 1; i++)
            {
                v[i] = v[i + 1];
            }
            v[n - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", v));
            Console.ReadKey();
        }

    }
}
