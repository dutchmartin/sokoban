using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class MazeFactory
    {

        public DoublyLinkedMatrix CreateMaze(String level)
        {
            String[] LevelLines = level.Split(
            new[] { "\r\n", "\r", "\n" },
            StringSplitOptions.None
            );

            // Set up the matrix.
            var Matrix = new DoublyLinkedMatrix(MatrixItemsFromString(LevelLines[0]));
            // Add more Rows.
            for (int i = 1; i < LevelLines.Length; i++)
            {
                Matrix.AddRow(MatrixItemsFromString(LevelLines[i]));
            }
            return Matrix;
        }

        private static MatrixItem[] MatrixItemsFromString(String BoardItemRow)
        {
            MatrixItem[] Row = new MatrixItem[BoardItemRow.Length];
            var chars = BoardItemRow.ToCharArray();
            for(int i = 0; i < chars.Length; i++)
            {
                Row[i] = MatrixItemFactory.Create(chars[i]);
            }
            return Row;
        }
    }
}
