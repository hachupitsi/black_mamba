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
            Console.SetBufferSize(120, 30);

            HorLine upLine = new HorLine(0, 79, 0, '-');
            upLine.DrawLine();

            HorLine downLine = new HorLine(0, 79, 29, '-');
            downLine.DrawLine();

            VertLine leftLine = new VertLine(0, 1, 28, '|');
            leftLine.DrawLine();

            VertLine rightLine = new VertLine(79, 1, 28, '|');
            rightLine.DrawLine();

            Point p = new Point(1, 1, '*');
            Snake blackMamba = new Snake(p, 4, Direction.RIGHT);
            blackMamba.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 30, '?');
            Point food = foodCreator.Create();
            food.Draw();
            
            while (true)
            {
                if (blackMamba.Eat(food))
                {
                    food = foodCreator.Create();
                    food.Draw();
                }
                else
                    blackMamba.Move();

                Thread.Sleep(200);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    blackMamba.changeDirection(key.Key);
                }
            }
        }
    }
}
