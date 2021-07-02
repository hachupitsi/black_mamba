using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class VertLine : Figure
    {
        public VertLine(int x, int yUp, int yDown, char sym)
        {
            line = new List<Point>();
            for (int y = yUp; y <= yDown; y++)
            {
                p = new Point(x, y, sym);
                line.Add(p);
            }
        }
    }
}
