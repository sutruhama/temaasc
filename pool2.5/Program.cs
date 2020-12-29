using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nreg = 0; ;
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x == i)
                    nreg++;
            }
            Console.WriteLine("Exista" + " " + nreg + " " + "numere egale cu pozitia lor");
            Console.ReadKey();
        }
    }
}
