using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task1
{
    internal class Solution
    {
        public static bool GetResult(Rect rect1, Rect rect2)
        {
            if (rect1 is null && rect2 is null)
                return false;

            return !(rect2.X1 >= rect1.X2 || rect2.X2 <= rect1.X1 || rect2.Y1 >= rect1.Y2 || rect2.Y2 <= rect1.Y1);
        }
    }
}
