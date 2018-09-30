using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public interface isMovable
    {
        bool canMove(Directions direction);

        void Move(Directions direction);
    }
}