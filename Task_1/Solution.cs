using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Solution
    {

        public static int GetResult(int m, int n)
        {
            int stepM = m;
            int stepN = n;

            while (m != n)
            {
                if (m < n)
                {
                    m += stepM;
                }
                else
                {
                    n += stepN;
                }
            }

            return m;
        }

        public static int GetResult(int m, int n, int k) => GetResult(GetResult(m, n), k);
        public static int GetResult(int m, int n, int k, int g) => GetResult(GetResult(GetResult(m, n), k), g);
        public static int GetResult(int m, int n, int k, int g, int h) => GetResult(GetResult(GetResult(GetResult(m, n), k), g), h);
    }
}
