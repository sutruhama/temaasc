using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j <n; j++)
                {
                    if (a[i] == a[j])
                    {
                        for (int k = j; k < n; k++)
                        {
                            if (k != n - 1)
                            {
                                int temp = a[k];
                                a[k] = a[k + 1];
                                a[k + 1] = temp;

                            }
                        }
                        j--;
                        n--;
                    }
                }

            }
            for (int i = 0; i < n; i++)
                Console.Write(a[i] + " ");
            Console.ReadKey();
        }
    }
}
