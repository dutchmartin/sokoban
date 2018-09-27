using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class MazeContainer
    {
        public MazeItem[][] _Items { get; private set; }

        public MazeContainer()
        {

        }

        public MazeItem GetItemAt(int xIndex, int yIndex)
        {
            throw new System.NotImplementedException();
        }
    }

    public class Maze
    {
        private MazeContainer _maze;

        public Maze( MazeContainer maze)
        {
            this._maze = maze;
        }
    }
}