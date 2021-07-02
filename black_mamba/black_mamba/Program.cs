using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace black_mamba
{
    class Program
    {
        static void Main(string[] args)
        {
            HorLine upLine = new HorLine(0, 60, 0, '#');
            upLine.DrawLine();

            HorLine downLine = new HorLine(0, 60, 30, '#');
            downLine.DrawLine();

            VertLine leftLine = new VertLine(0, 1, 29, '#');
            leftLine.DrawLine();

            VertLine rightLine = new VertLine(60, 1, 29, '#');
            rightLine.DrawLine();

            Point p = new Point(1, 1, '*');
            Snake s = new Snake(p, 8, Direction.DOWN);
            s.DrawLine();
            
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    s.changeDirection(key.Key);
                }
                Thread.Sleep(300);
                s.Move();
            }
        }
    }
}
