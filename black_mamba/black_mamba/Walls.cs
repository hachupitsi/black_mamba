using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class Walls
    {
        public List<Figure> walls;

        public Walls(int mapWidth, int mapHeight)
        {
            walls = new List<Figure>();
            HorLine upLine = new HorLine(0, mapWidth - 1, 0, '-');
            HorLine downLine = new HorLine(0, mapWidth - 1, mapHeight - 1, '-');
            VertLine leftLine = new VertLine(0, 1, mapHeight - 2, '|');
            VertLine rightLine = new VertLine(mapWidth - 1, 1, mapHeight - 2, '|');

            walls.Add(upLine);
            walls.Add(downLine);
            walls.Add(leftLine);
            walls.Add(rightLine);
        }

        public void DrawWalls()
        {
            foreach (var wall in walls)
            {
                wall.DrawLine();
            }
        }

        public bool IsHit(Figure figure)
        {
            foreach (var wall in walls)
            {
                if (wall.IsHit(figure))
                    return true;
            }
            return false;
        }
    }
}
