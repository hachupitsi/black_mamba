using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class Snake : Figure
    {
        public Direction dir;
        Point head;

        public Snake(Point tail, int lenght, Direction _dir)
        {
            dir = _dir;
            line = new List<Point>();
            for (int x = 0; x <= lenght; x++)
            {
                Point p = new Point(tail);
                p.Move(x, dir);
                line.Add(p);
            }
        }

        public void Move()
        {
            line.First().Clear();
            line.Remove(line.First());
            line.Add(GetNextPoint());
            line.Last().Draw();
        }

        public Point GetNextPoint()
        {
            Point nextPoint = new Point(line.Last());
            nextPoint.Move(1, dir);
            return nextPoint;
        }

        public void changeDirection(ConsoleKey key)
        {
            if (key == ConsoleKey.RightArrow)
                dir = Direction.RIGHT;
            else if (key == ConsoleKey.LeftArrow)
                dir = Direction.LEFT;
            else if (key == ConsoleKey.UpArrow)
                dir = Direction.UP;
            else if (key == ConsoleKey.DownArrow)
                dir = Direction.DOWN;
        }

        public bool Eat(Point food)
        {
            head = GetNextPoint();
            if (head.Equal(food))
            {
                food.sym = head.sym;
                line.Add(food);
                return true;
            }
            else
                return false;
        }

        public bool IsHitTail()
        {
            head = line.Last();
            for (int i = 0; i < line.Count() - 1; i++)
            {
                if (line[i].Equal(head))
                    return true;
            }
            return false;
        }

        public void die()
        {
            line.Clear();
        }

        public int lenght()
        {
            return line.Count();
        }
    }
}
