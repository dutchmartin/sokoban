using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        public MatrixItem[] Destinations { get; set; }
        public Player Player { get; set; }
        public DoublyLinkedMatrix Board { get; set; }

        public Game(DoublyLinkedMatrix board)
        {
            Board = board;
        }
        public void DoMove()
        {
            throw new System.NotImplementedException();
        }
    }
}