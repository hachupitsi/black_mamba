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
    }
}
