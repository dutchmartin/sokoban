using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Sleeper: MazeItem, isMovable
    {
        public bool awake{get; protected set;}
        private Random random;

        public Sleeper()
        {
            view = 'Z';
            awake = false;
            random = new Random();
        }

        public void NextCycle()
        {
            if(awake == true)
            {
                Move(Directions.Left);
                if(random.Next(1,4) == 1)
                {
                    awake = false;
                    this.view = 'Z';
                }
            }
            else 
            {
                if(random.Next(1,2) == 1)
                {
                    awake = true;
                    this.view = '$';
                }
            }
        }

        public bool canMove(Directions direction)
        {
            if(!awake)
                awake = true;

            return false;
        }
        public void Move(Directions direc)
        {
            // int move = random.Next(1,4);
            int move = 1;
            Directions direction = Directions.Right;
            switch(move)
            {
                case 1:
                    direction = Directions.Left;
                    break;
                case 2:
                    direction = Directions.Right;
                    break;
                case 3:
                    direction = Directions.Up;
                    break;
                case 4:
                    direction = Directions.Down;
                    break;
            }

            MatrixItem nextLocation = getNextLocation(direction);
            if(!(nextLocation.occupant is isMovable && nextLocation.occupant != null))
            {
                return;
            }
            else if(nextLocation.occupant is isMovable)
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