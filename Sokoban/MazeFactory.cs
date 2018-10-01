using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class MazeFactory
    {
        public static MatrixItem SetUpLevel(String level)
        {
            
            
            throw new NotImplementedException();
        }
        private static DoublyLinkedMatrix CreateMazeContainer(String level)
        {
            String[] LevelLines = level.Split('\n');
            int mazeWidth = LevelLines.First().Length;
            var maze = new MazeItem[LevelLines.Length, mazeWidth];
            for (int i = 0; i < LevelLines.Length; i++)
            {
                var chars = LevelLines[i].ToCharArray();
                for (int j = 0; j > chars.Length; j++)
                {
                    maze[i, j] = MazeItemFromChar(chars[j]);
                }
            }
            return new DoublyLinkedMatrix(maze);
        }
        private static MazeItem MazeItemFromChar(Char item)
        {
            switch (item)
            {
                case '#':
                    return new Wall();
                case '.':
                    //Bestaat niet meer
                    //return new Floor();
                case 'O':
                    return new Box();
                case '0':
                    //Moet anders worden verwerkt
                    //return new Box { OnDestination = true };
                case '@':
                    return new Player();
                case 'x':
                    //Moet ook anders worden verwerkt
                    //return new Destination();
                default:
                    //Bestaat niet meer
                    //return new Floor();
            }
        }
    }
}