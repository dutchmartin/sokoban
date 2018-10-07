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
            var item = MatrixItemFromChar(input);
            var MatrixItem = new MatrixItem() { occupant = item };
            if (item != null)
            {
                item.location = MatrixItem;
            }
            else if ( input == 'x')
            {
                MatrixItem.IsDestination = true;
            }
            return MatrixItem;
        }
        private static MazeItem MatrixItemFromChar(Char item)
        {

            switch (item)
            {
                case '#':
                    return new Wall();
                case 'o':
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
