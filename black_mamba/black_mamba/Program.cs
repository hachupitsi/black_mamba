using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class Program
    {
        static void Main(string[] args)
        {
            HorLine upLine = new HorLine(0, 30, 0, '#');
            upLine.DrawLine();

            HorLine downLine = new HorLine(0, 30, 30, '#');
            downLine.DrawLine();

            VertLine leftLine = new VertLine(0, 1, 29, '#');
            leftLine.DrawLine();

            VertLine rightLine = new VertLine(30, 1, 29, '#');
            rightLine.DrawLine();

            Point p = new Point(1, 1, '*');
            Snake s = new Snake(p, 8, Direction.DOWN);
            s.DrawLine();

            Console.ReadKey();
        }
    }
}
