﻿
namespace Tetris.Domain.Blocks
{
    public class IBlock : Block
    {
        public override Tile[][] States => throw new System.NotImplementedException();        

        public override void RotateCCW()
        {
            throw new System.NotImplementedException();
        }

        public override void RotateCW()
        {
            throw new System.NotImplementedException();
        }
    }
}
