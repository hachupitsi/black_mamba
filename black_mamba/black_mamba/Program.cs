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

            Walls walls = new Walls(80, 30);
            walls.DrawWalls();

            Point p = new Point(1, 1, '*');
            Snake blackMamba = new Snake(p, 4, Direction.RIGHT);
            blackMamba.DrawLine();

            FoodCreator foodCreator = new FoodCreator(80, 30, '?');
            Point food = foodCreator.Create();
            food.Draw();

            while ((!walls.IsHit(blackMamba)) && (!blackMamba.IsHitTail()))
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

            Console.SetCursorPosition(30, 14);
            Console.Write("Game over");
            Console.ReadKey();
        }
    }
}
