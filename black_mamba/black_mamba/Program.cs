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
            Point p1 = new Point(3, 4, '*');
            p1.Draw();

            Point p2 = new Point(8, 3, 'o');
            p2.Draw();

            HorLine upLine = new HorLine(0, 30, 0, '#');
            upLine.DrawLine();

            HorLine downLine = new HorLine(0, 30, 30, '#');
            downLine.DrawLine();

            VertLine leftLine = new VertLine(0, 1, 29, '#');
            leftLine.DrawLine();

            VertLine rightLine = new VertLine(30, 1, 29, '#');
            rightLine.DrawLine();

            Console.ReadKey();
        }
    }
}
