using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Box : MazeItem, isMovable
    {
        public bool canMove(Directions direction)
        {
            if(getNextLocation(direction).occupant== null)
            {
                return true;
            }

            return false;
        }

        public void Move(Directions direction)
        {
            MatrixItem nextLocation = getNextLocation(direction);
            /*Eerst het huidige hoke leegmaken
             * daarna this in het nextitem stoppen
             * daarna location veranderen naar nextitem
             */
            location.occupant = null;
            location = nextLocation;
            location.occupant = this;
        }
    }
}