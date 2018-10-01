using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Board
    {
        public Player _player = new Player();
        public MatrixItem[] destinations;
        
        public void doMove(Directions direction)
        {
            _player.canMove(direction);
            _player.Move(direction);
            CheckFinish();
        }

        private bool CheckFinish()
        {
            foreach(MatrixItem item in destinations)
            {
                if (item.occupant == null)
                    return false;
            }
            return true;
        }
        
    }
}