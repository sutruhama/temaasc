using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._19
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,k=0;
            Random rnd = new Random();
            n = rnd.Next();
            Console.WriteLine(n);
            while(n>0)
            {
                int c = n % 10;
                for (int i = 0; i <= 9; i++)
                {

                    int[] v = new int[10];
                    if (c == i)
                        v[i]++;


                    n = n / 10;
                    k++;
                }
            }
            if (k == 2)
                Console.WriteLine("numarul e format doar cu 2 cifre care se pot repeta");
            else
                Console.WriteLine("numarul nu e format doar cu 2 cifre care se pot repeta");
            Console.ReadKey();
        }
       
    }
}
