using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Solution
    {
        public static double CalculateFunction(double a, double b, double c, double x)
        {
            double result;

            int Ac = (int)a, Bc = (int)b, Cc = (int)c;

            if (a < 0 && c != 0)
            {
                result = a * Math.Pow(x, 2) + b * x + c;
            }
            else if (a > 0 && c == 0)
            {
                if (x == c)
                {
                    throw new DivideByZeroException("Деление на 0");
                }
                result = -a / (x - c);
            }
            else
            {
                result = a * (x - c);
            }

            if ((Ac & (Bc | Cc)) != 0)
            {
                return result;
            }
            else
            {
                return (int)result;
            }
        }

    }
}
