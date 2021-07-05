using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class Figure
    {
        protected List<Point> line;
        protected Point p;

        public void DrawLine()
        {
            foreach (Point p in line)
            {
                p.Draw();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var p in line)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }

        public bool IsHit(Point point)
        {
            foreach (var p in line)
            {
                if (point.Equal(p))
                    return true;
            }
            return false;
        }
    }
}
