

namespace Tetris.Domain
{
    public class Field
    {
        protected const int WIDTH = 10;
        protected const int HEIGHT = 22;
        protected Tile[,] field { get; set; } = new Tile[WIDTH, HEIGHT];
        protected void TileInit()
        {
            
        }

        public int RowsCount { get; } = HEIGHT - 2;
        public int ColumnsCount { get; } = WIDTH;

        public Tile this[int row, int col] => field[row, col];                
    }
}
