using Tetris.Domain.Blocks;

namespace Tetris.Domain
{
    public class Game
    {
        public Field Field { get; private set; }
        public Block CurrentBlock { get; private set; }
        public Block NextBlock { get; private set; }
        public BlockCreator BlockCreator { get; private set; }

        public int Update()
        {
            return 10 * 2;
        }

        public void RotateBlockCW()
        {

        }

        public void RotateBlockCCW()
        {

        }

        public void MoveBlockDown()
        {

        }

        public void MoveBlockLeft()
        {

        }

        public void MoveBlockRight()
        {

        }
    }
}
