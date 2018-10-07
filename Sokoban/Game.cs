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
        private GameViewModel view;

        public Game(DoublyLinkedMatrix board)
        {
            view = new GameViewModel(this);
            Board = board;
            player = board.player;
        }
        public void Play()
        {
            int steps = 0;
            while(!CheckIfWon())
            {
                view.Render();
                // Handle input.
                this.DoMove(InputMapper.GetInputDirection());
                steps++;
            }
            Console.WriteLine("Je hebt met {0} stappen gewonnen!", steps);
            Console.ReadLine();
        }

        public void DoMove(Directions direct)
        {
            player.Move(direct);
            view.Render();
        }
        private bool CheckIfWon()
        {
            foreach(var item in Destinations )
            {
                if (! (item.occupant is Box))
                    return false;
            }
            return true;
        }
    }
}