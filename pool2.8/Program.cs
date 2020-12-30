using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("n = ");
            n = int.Parse(Console.ReadLine());
            int nr_2=0, nr_1, nr_0;
            nr_0 = 1;
            nr_1 = 1;
            for (int i = 3; i <= n; i++)
            {
                nr_2 = nr_1 + nr_0;
                nr_0 = nr_1;
                nr_1 = nr_2;
                
            }
            Console.WriteLine(nr_2);
            Console.ReadKey();
        }
    }

}
