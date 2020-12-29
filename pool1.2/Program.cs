using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, x, delta, x1, x2;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a == 0)

                if (b == 0)

                    if (c == 0)

                        Console.WriteLine("Exista o infinitate de solutii!");

                    else

                        Console.WriteLine("Ecuatie imposibila!");

                else

                {
                    Console.WriteLine("Ecuatie de gr I cu solutia ");

                    x = -c / b;

                    Console.WriteLine(x);

                }

            else

            {
                delta = Math.Pow(b, 2) - 4 * a * c;

                if (delta < 0)

                    Console.WriteLine("Ecuatia nu are solutii reale!");

                else

                   if (delta == 0)

                {
                    Console.WriteLine("Ecuatia are solutii egale!");


                    Console.WriteLine("x1 = x2" + " " + (-b / (2 * a)));

                }

                else

                {
                    x1 = (-b + Math.Sqrt(delta)) / 2 * a;

                    x2 = (-b - Math.Sqrt(delta)) / 2 * a;

                    Console.WriteLine("Ecuatia are solutii reale!");

                    Console.WriteLine("x1=" + x1);

                    Console.WriteLine("x2=" + x2);

                }
            }
        }
    }
}
