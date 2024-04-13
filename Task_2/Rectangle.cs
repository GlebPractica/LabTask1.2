using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Rect
    {
        public int X1 { get; private set; }
        public int Y1 { get; private set; }
        public int X2 { get; private set; }
        public int Y2 { get; private set; }

        public Rect(int x1, int y1, int x2, int y2) 
        {
            X1 = Math.Min(x1, x2);
            Y1 = Math.Min(y1, y2);
            X2 = Math.Max(x1, x2);
            Y2 = Math.Max(y1, y2);
        }
    }
}
