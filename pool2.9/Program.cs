using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool2._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n=int.Parse(Console.ReadLine());
            int a = int.Parse(Console.ReadLine());
            int i;
                bool increasing = true;
                bool decreasing = true;
            for (i = 0; i < n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                if (a > b)
                {
                    increasing = false;
                }
                else if (a < b)
                {
                    decreasing = false;
                }
                a = b;
            }
                    if (increasing==false && decreasing==false)
                    {
                    Console.WriteLine("Secventa nu e monotona");
                    }

                
            if (increasing == true)
                Console.WriteLine("Secventa e crescatoare");
            else
                if (decreasing == true)
                Console.WriteLine("Secventa e descrescatoare");


                Console.ReadKey();
            }
    }
}
