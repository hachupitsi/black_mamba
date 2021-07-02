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

            HorLine h = new HorLine(3, 10, 4, '#');
            h.DrawLine();

            VertLine v = new VertLine(11, 1, 5, '.');
            v.DrawLine();

            Console.ReadKey();
        }
    }
}
