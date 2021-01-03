using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            int[] b=new int[n];
            int index;
            int place;
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
            {
                index = i - k;
                place = n + index;
                if (index >= 0)
                {
                    b[index] = v[i];
                }
                else
                {
                    b[place] = v[i];
                }
            }
            for (int i = 0; i < n; i++)
                Console.WriteLine(b[i] + " ");
            Console.ReadKey();
        }
    }
}
