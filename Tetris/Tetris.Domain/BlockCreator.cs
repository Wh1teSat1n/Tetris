using System;
using Tetris.Domain.Blocks;

namespace Tetris.Domain
{
    public class BlockCreator
    {
        protected Block[] blocks =
        {
            new IBlock(),
            new JBlock(),
            new LBlock(),
            new OBlock(),
            new SBlock(),
            new TBlock(),
            new ZBlock()
        };
        public Block NextBlock()
        {
            Random rand = new Random();

            return blocks[rand.Next(blocks.Length)];
        }
    }
}
