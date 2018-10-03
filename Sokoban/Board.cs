using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Board
    {
        public Player _player = new Player();
        public MatrixItem[] destinations;
        public DoublyLinkedMatrix boardModel = new DoublyLinkedMatrix();
        TypeToCharDictionary representation = new TypeToCharDictionary();


        public List<string> getRenderArray()
        {
            //MatrixItem element = boardModel.Origin;
            
            List<string> result = new List<string>();
            string line;
            char elementVisual = '.';
            MatrixItem mostLeftElement = boardModel.Origin;
            MatrixItem element = boardModel.Origin;

            while (mostLeftElement != null)
            {
                line = "";
                while(element.East != null)
                {
                    line += elementVisual + " ";
                    elementVisual = GetElementVisual(element.occupant);
                    element = element.East;
                }
                result.Add(line);
                mostLeftElement = mostLeftElement.South;
                element = mostLeftElement;            
            }

            return result;
        }

        public char GetElementVisual(MazeItem element)
        {
            if(element == null)
            {
                return '.';
            }

            if(!(element is isMovable))
            {
                return '#';
            }
            
            if(!(element is isPusher))
            {
                return '0';
            }

            return '@';
        }

        public void doMove(Directions direction)
        {
            _player.canMove(direction);
            _player.Move(direction);
            CheckFinish();

        }

        private bool CheckFinish()
        {
            foreach(MatrixItem item in destinations)
            {
                if (item.occupant == null)
                    return false;
            }
            return true;
        }
        
    }
}