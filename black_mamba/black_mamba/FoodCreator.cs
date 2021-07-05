using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace black_mamba
{
    class FoodCreator
    {
        int mapWidth;
        int mapHight;
        char sym;

        Random rand = new Random();

        public FoodCreator(int mapWidth, int mapHight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public Point Create()
        {
            int x = rand.Next(1, mapWidth - 2);
            int y = rand.Next(1, mapHight - 2);
            return new Point(x, y, sym);
        }
    }
}
