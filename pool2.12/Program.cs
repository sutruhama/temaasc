using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = 0,i;
            int n = int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            for(i=0;i<n;i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a == 0 && (i + 1 == n || b != 0))
                    groups++;
               
                
            }
            Console.WriteLine("Numarul de grupuri este" + " " + groups);
            Console.ReadKey();
        }
    }
}
