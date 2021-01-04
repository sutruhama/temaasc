using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] v = new int[n];
            for (int i = 0; i < n; i++)
                v[i] = int.Parse(Console.ReadLine());
            int cmmdc = v[1];
            for (int i = 1; i < n; i++)
            {

                int copieEL = v[i];
                while (copieEL != cmmdc)
                {

                    if (copieEL > cmmdc)
                        copieEL = copieEL - cmmdc;
                    else if (copieEL < cmmdc)
                        cmmdc = cmmdc - copieEL;
                }
            }
            Console.WriteLine("Cel mai mare divizor comun este" + " " + cmmdc);
            Console.ReadKey();
        }
    }
}
