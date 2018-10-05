using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Game
    {
        public MatrixItem[] Destinations { get; set; }
        public Player player { get; set; }
        public DoublyLinkedMatrix Board { get; set; }

        public Game(DoublyLinkedMatrix board)
        {
            Board = board;
            getDestinations();
            player = new Player();
        }
        public void DoMove(Directions direct)
        {
            player.Move(direct);
        }

        private void getDestinations()
        {
            int i = 0;
            MatrixItem leftHelper = Board.Origin;
            MatrixItem currentElement = leftHelper;
            while (currentElement != null)
            {
                
                do
                {
                    if (currentElement.isDestination)
                    {
                        Destinations[i] = currentElement;
                        i++;
                    }

                    currentElement = currentElement.East;
                } while (currentElement != null);
                leftHelper = leftHelper.South;
                currentElement = leftHelper;
            }
        }
    }
}