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
            }
        }

        public MazeItem GetItemAt(int xIndex, int yIndex)
        {
            throw new System.NotImplementedException();
        }
    }
}