using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class MazeItem
    {
        public MatrixItem location { get; set; }

        public MatrixItem getNextLocation(Directions direction)
        {
            MatrixItem result = new MatrixItem();

            switch (direction)
            {
                case Directions.Right:
                    result = location.East;
                    break;
                case Directions.Left:
                    result = location.West;
                    break;
                case Directions.Up:
                    result = location.North;
                    break;
                case Directions.Down:
                    result = location.South;
                    break;
            }

            return result;
        }
    }
}