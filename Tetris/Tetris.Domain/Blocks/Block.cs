using Tetris.Domain;

namespace Tetris.Domain.Blocks
{
    /// <summary>
    /// Игровой блок, движущийся в зависимости от ввода игрока
    /// </summary>
    public abstract class Block
    {
        protected int currentStateIndex = 0;
        /// <summary>
        /// Текущее положение блока относительно центра поворота
        /// </summary>
        protected Tile[] currentState;        

        /// <summary>
        /// Положения блока относительно центра поворота
        /// </summary>
        public abstract Tile[][] States { get; }        
        public Block() 
        {             
            currentState = States[currentStateIndex];
        }

        /// <summary>
        /// Поворот блока на 90 градусов по часовой стрелке
        /// </summary>        
        public abstract void RotateCW();
        public abstract void RotateCCW();
    }
}
