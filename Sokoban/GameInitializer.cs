using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class GameInitializer
    {
        private string _Level = null;
        public GameInitializer AskLevelToPlay()
        {
            _Level = new LevelChooser().GetTheLevelTheUserWants();
            return this;
        }
        public Game AssembleGame()
        {
            if (_Level == null)
                return null;
            DoublyLinkedMatrix matrix = new MazeFactory().CreateMaze(_Level);
            return new Game(matrix);
        }
    }
}