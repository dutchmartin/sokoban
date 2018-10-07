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
            System.Console.Clear();
            _board = _game.Board;
            MatrixItem leftHelper = _board.Origin;
            MatrixItem currentElement = leftHelper;
            string line;
            while(currentElement != null)
            {
                line = "";
                do
                {
                    if(currentElement.occupant == null)
                    {
                        if (currentElement.IsDestination)
                        {
                            line += 'x';
                        }
                        else
                        {
                            line += ".";
                        }
                    }
                    else
                    {
                        line += currentElement.occupant.view;
                    }
                    currentElement = currentElement.East;
                }
                while (currentElement != null);
                leftHelper = leftHelper.South;
                currentElement = leftHelper;
                Console.WriteLine(line);
            }
            Console.WriteLine("");
            Console.WriteLine("Laat met de pijltjestoetsen de speler bewegen.");
        }
    }
}