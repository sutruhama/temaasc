using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pool3._18
{
    class Program
    {
        public static double F(List<double> coeffs, double x)
        {
            double total = 0;
            double x_factor = 1;
            for (int i = 0; i < coeffs.Count; i++)
            {
                total += x_factor * coeffs[i];
                x_factor *= x;
            }
            return total;
        }
    }
}
