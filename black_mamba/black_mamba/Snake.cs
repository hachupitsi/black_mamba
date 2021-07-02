using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class Snake : Figure
    {
        public Snake(Point tail, int lenght, Direction dir)
        {
            line = new List<Point>();
            for (int x = 0; x <= lenght; x++)
            {
                Point p = new Point(tail);
                p.Move(x, dir);
                line.Add(p);
            }
        }
    }
}
