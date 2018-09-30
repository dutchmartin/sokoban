﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Player : MazeItem, isMovable
    {
        public bool canMove(Directions direction)
        {
            MazeItem nextItem = getNextLocation(direction).occupant; 

            if (nextItem == null)
                return true;

            if(!(nextItem is isMovable))
            {
                return false;
            }

            isMovable nextMoveableItem = (isMovable)nextItem;

            return nextMoveableItem.canMove(direction);
        }

        public void Move(Directions direction)
        {
            if (!canMove(direction))
                return;

            MatrixItem nextLocation = getNextLocation(direction);

            if(nextLocation.occupant is isMovable)
            {
                isMovable nextItem = (isMovable)nextLocation.occupant;
                nextItem.Move(direction);
            }

            location.occupant = null;
            location = nextLocation;
            location.occupant = this;

        }
    }
}