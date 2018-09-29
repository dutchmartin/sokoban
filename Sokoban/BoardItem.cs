using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public abstract class MazeItem : MatrixItem
    {
        public char _value { get; protected set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}