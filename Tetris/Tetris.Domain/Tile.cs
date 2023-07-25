

namespace Tetris.Domain
{
    public class Tile
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public bool IsEmpty { get; set; }

        public Tile(int row, int column)
        {
            Row = row;
            Column = column;
            IsEmpty = true;
        }
    }
}
