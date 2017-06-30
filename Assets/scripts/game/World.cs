using System.Collections;
using System.Collections.Generic;

namespace game
{
    public class World
    {
        public World(int colums, int rows)
        {
            Tiles = new List<Tile>();
            for(int column = 0; column < colums; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    Tiles.Add(new Tile(column, row));
                }
            }
        }

        public List<Tile> Tiles;
    }
}