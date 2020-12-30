using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1, longestcount = 0, longestnr = 0;
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                
                int b = int.Parse(Console.ReadLine());
                if (b != a)
                    count = 0;
                count++;
                if (count > longestcount)
                {
                    longestcount = count;
                    longestnr =b;
                }
                a = b;
            }
            Console.WriteLine("Numarul maxim de numere egale conescutive este"+" "+longestcount);
            Console.ReadKey();
        }
    }
}
