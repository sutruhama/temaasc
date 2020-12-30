using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0,invers,a,i=0;
            int n = int.Parse(Console.ReadLine());
            while(i<n)
            {
                 a = int.Parse(Console.ReadLine());
                invers = 0;
                while (a>0)
                {
                    
                    invers = invers * 10 + a % 10;
                    a = a / 10;
                }
                suma = suma + invers;
                i++;
            }
            Console.WriteLine("suma inverselor este" + " " + suma);
            Console.ReadKey();
        }
    }
}
