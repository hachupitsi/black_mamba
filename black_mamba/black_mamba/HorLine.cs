using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class HorLine : Figure
    {
        public HorLine(int xLeft, int xRight, int y, char sym)
        {
            line = new List<Point>();
            for (int x = xLeft; x <= xRight; x++)
            {
                p = new Point(x, y, sym);
                line.Add(p);
            }
        }
    }
}
