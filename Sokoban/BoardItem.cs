using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class MazeItem
    {
        public MatrixItem location { get; set; }

        public void Move()
        {
            throw new System.NotImplementedException();
        }

        public bool CheckMoveability()
        {
            throw new System.NotImplementedException();
        }
    }
}