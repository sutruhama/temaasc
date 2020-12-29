using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, nrnegative = 0, nrpozitive = 0, nrnule = 0;
            n=int.Parse(Console.ReadLine());
            for(int i=0;i<n;i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x < 0)
                    nrnegative++;
                else
                if (x > 0)
                    nrpozitive++;
                else
                    nrnule++;
            }
            Console.WriteLine("Exista" + " " + nrnegative + " " + "numere negative");
            Console.WriteLine("Exista" + " " + nrpozitive + " " + "numere pozitive");
            Console.WriteLine("Exista" + " " + nrnule + " " + "numere nule");
            Console.ReadKey();

        }
    }
}
