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
            var destinations = getDestinations(matrix);
            return new Game(matrix) { Destinations = destinations };
        }
        private MatrixItem[] getDestinations(DoublyLinkedMatrix matrix)
        {
            List<MatrixItem> destinations = new List<MatrixItem>();
            MatrixItem currentElement = matrix.Origin;
            while (currentElement.South != null)
            {
                var innerCurrentElement = currentElement;
                do
                {
                    if (innerCurrentElement.IsDestination)
                        destinations.Add(innerCurrentElement);
                    innerCurrentElement = innerCurrentElement.East;
                }
                while (innerCurrentElement.East != null);
                // Move one line lower
                currentElement = currentElement.South;
            }
            return destinations.ToArray();
        }
    }
}