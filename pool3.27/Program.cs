using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("size of array:" + " ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int index;
            Console.Write("The value of index is:");
                index = int.Parse(Console.ReadLine());
            Console.WriteLine("The numbers of array:");
            for (int i = 0; i < n; i++)
                arr[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for(int j=0;j<n-1;j++)
                    if(arr[i]<arr[j])
                    {
                        int aux = arr[i];
                        arr[i] = arr[j];
                        arr[j] = aux;
                    }
            }
            Console.WriteLine("The sorted array:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
                for (int i = 0; i < n; i++)
            {
                if (i == index)
                    Console.WriteLine("The value is" + " " + arr[i]);
            }
            Console.ReadKey();
        }
    }
}
