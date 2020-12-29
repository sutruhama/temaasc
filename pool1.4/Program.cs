using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int y;
            y = int.Parse(Console.ReadLine());
            if ((y % 4 == 0) && (y % 100 != 0))
                Console.WriteLine("anul este bisect");
            if (y % 400 == 0)
                Console.WriteLine("anul este bisect");
            Console.WriteLine("anul nu este bisect");
            Console.ReadKey();
        }
    }
}
