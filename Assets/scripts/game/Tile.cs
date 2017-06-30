using System.Collections;
using System.Collections.Generic;

namespace game
{
    public class Tile
    {
        public Tile(int column, int row)
        {
            Column = column;
            Row = row;
        }

        private int column;
        private int row;

        public int Column{ get { return column; } private set { column = value; } }
        public int Row { get { return row; } private set { row = value; } }
        public int Sum { get { return -(Column + Row); } }

        
    }
}