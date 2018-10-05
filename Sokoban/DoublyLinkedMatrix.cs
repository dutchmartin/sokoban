using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    // This class is responsable for managing the data of the game.
    public class DoublyLinkedMatrix
    {
        public MatrixItem Origin { get; set; }
        public MatrixItem End { get; set; }
        private int Width;

        public DoublyLinkedMatrix(MatrixItem[] FirstRow)
        {
            Width = FirstRow.Length;
            MatrixItem LastItem = null;
            foreach( MatrixItem item in FirstRow )
            {
                if (Origin == null)
                {
                    Origin = item;
                }
                else
                {
                    LastItem.East = item;
                    item.West = LastItem;
                }
                LastItem = item;
            }
            End = LastItem;
        }

        public void AddRow(MatrixItem[] Row)
        {
            if(Width == Row.Length)
            {
                MatrixItem LastItem = null;
                MatrixItem SouthWestCorner = GetSouthWestCornerItem();
                foreach (MatrixItem item in Row)
                {
                    if (LastItem == null)
                    {
                        // Set up the first item of the row.
                        SouthWestCorner.South = item;
                        item.North = SouthWestCorner;
                    }
                    else
                    {
                        // Connect the rest of the items to the Matrix.
                        var Above = LastItem.North.East;
                        LastItem.East = item;
                        item.West = LastItem;
                        Above.South = item;
                        item.North = Above;
                    }
                    LastItem = item;
                }
            }
        }

        public MatrixItem GetSouthWestCornerItem()
        {
            MatrixItem current = Origin;
            while(current.South != null)
            {
                current = current.South;
            }
            return current;
        }
    }
}
