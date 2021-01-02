using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                suma = suma + v[i];
            Console.WriteLine("Suma este" + " " + suma);
            Console.ReadKey();


        }
    }
}
