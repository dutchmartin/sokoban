using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class MatrixItemFactory
    {
        public static MatrixItem Create(Char input)
        {
            return new MatrixItem() { occupant = MazeItemFromChar(input) };
        }
        private static MazeItem MazeItemFromChar(Char item)
        {
            switch (item)
            {
                case '#':
                    return new Wall();
                case 'O':
                    return new Box();
                case '@':
                    return new Player();
                default:
                    // This will result in a floor.
                    return null;
            }
        }
    }
}
