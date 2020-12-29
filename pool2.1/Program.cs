using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nrpare = 0; ;
            n = int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    nrpare++;
            }
            Console.WriteLine("Exista" + " " + nrpare + " " + "numere pare");
            Console.ReadKey();
        }
    }
}
