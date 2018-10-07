using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameViewModel : IRenderable
    {
        private Game _game;
        public DoublyLinkedMatrix _board;

        public GameViewModel(Game game)
        {
            _game = game;
        }

        public void Render()
        {
            _board = _game.Board;
            MatrixItem leftHelper = _board.Origin;
            MatrixItem currentElement = leftHelper;
            string line;
            while(currentElement != null)
            {
                line = "";
                do
                {
                    line += currentElement.occupant.view;
                    currentElement = currentElement.East;
                } while (currentElement != null);
                leftHelper = leftHelper.South;
                currentElement = leftHelper;
                Console.WriteLine(line);
            }
        }
    }
}