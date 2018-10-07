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
        public char view { get; protected set; }

        public Sleeper()
        {
            view = 'Z';
            awake = false;
            random = new Random();
        }

        public void NextCycle()
        {
            if(awake)
            {
                if(random.Next(1,101) >= 25)
                {
                    awake = false;
                    view = 'Z';
                }
            }
            else 
            {
                if(random.Next(1,101) >= 10)
                {
                    awake = true;
                    view = '$';
                }
            }
        }

        public bool canMove(Directions direction)
        {
            if(!awake)
                awake = true;

            return false;
        }
        public void Move(Directions direction)
        {
            int move = random.Next(1,4);
            Directions direct;
            switch(move)
            {
                case 1:
                    direct = Directions.Left;
                    break;
                case 2:
                    direct = Directions.Right;
                    break;
                case 3:
                    direct = Directions.Up;
                    break;
                case 4:
                    direct = Directions.Down;
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