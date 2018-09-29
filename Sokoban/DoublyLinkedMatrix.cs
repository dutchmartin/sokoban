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
                if (LastItem == null)
                {

                }
            }
        }

        public MazeItem GetItemAt(int xIndex, int yIndex)
        {
            throw new System.NotImplementedException();
        }
    }

    // This class contains the rules of the game.
    public class MatrixItem
    {
        public MatrixItem North { get; set; }
        public MatrixItem East { get; set; }
        public MatrixItem South { get; set; }
        public MatrixItem West { get; set; }


    }
}