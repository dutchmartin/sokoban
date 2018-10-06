using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            // Set up Game
            Game game = new GameInitializer().AskLevelToPlay().AssembleGame();
            // Play Game
            game.Play();
            // Ask player if he wants to continue.
        }
    }
}
