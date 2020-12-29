using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,n,y;bool ok = false; 
            n = int.Parse(Console.ReadLine());
            x = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<n)
            {
                y = int.Parse(Console.ReadLine());
                if (x < y)
                    ok = true;
                x = y;
                i++;
            }
            if (ok == true)
                Console.WriteLine("Sirul este crescator");
            else
                Console.WriteLine("Sirul nu este crescator");
            Console.ReadKey();
        }
    }
}
