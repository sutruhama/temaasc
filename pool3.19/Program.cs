using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce the size of first array");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce the size of second array");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];
            int[] arr2 = new int[n2];
            int k = 0;
            Console.WriteLine("Introduce the values of first array");
            for (int i = 0; i < n1; i++)
                arr1[i] = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce the values of second array");
            for (int i = 0; i < n1; i++)
                arr2[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i <n1; i++)
            {

                for (int j = 0; j < n2; j++)
                {

                    if (arr1[i] == arr2[j])
                    {
                        k++;
                        break;
                    }

                }

            }
            if (n1 == k)
            {
                Console.WriteLine(true);
            }
            else
                Console.WriteLine(false);
            Console.ReadKey();
        }
    }
    }

