using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class VertLine
    {
        List<Point> line;
        Point p;

        public VertLine(int x, int yLeft, int yRight, char sym)
        {
            line = new List<Point>();
            for (int y = yLeft; y <= yRight; y++)
            {
                p = new Point(x, y, sym);
                line.Add(p);
            }
        }

        public void DrawLine()
        {
            foreach (Point p in line)
            {
                p.Draw();
            }
        }
    }
}
