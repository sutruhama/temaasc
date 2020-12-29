using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n;
            n = rnd.Next(1, 1024);
            int x=0;
            Console.WriteLine("Introduceti un numar cuprins intre 1 si 1024");
         

            int i = 0;

            while (x != n)
            {
                try
                {
                    x = Convert.ToInt32(Console.ReadLine());

                    if (x > n)
                    {
                        Console.WriteLine("numarul e prea mare");
                    }
                    else
                    {
                        Console.WriteLine("numarul e prea mic");
                    }
                }

                catch
                {
                    Console.WriteLine("X trebuie sa fie un numar");
                    i--;
                }


                i++;
            }
            Console.WriteLine("Felicitari ati raspuns corect dupa " + i + " incercari");
            Console.ReadLine();
        }
    }
}
