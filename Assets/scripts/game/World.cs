using System.Collections;
using System.Collections.Generic;

namespace game
{
    public class World
    {
        public World(int colums, int rows)
        {
            Tiles = new Tile[rows, colums];
            for(int column = 0; column < colums; column++)
            {
                for (int row = 0; row < rows; row++)
                {
                    Tiles[row, column] = new Tile(column, row);
                }
            }
        }

        public Tile[,] Tiles;
    }
}