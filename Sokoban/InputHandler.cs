using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputHandler
    {
        public void GetArrowkeyInput(out ConsoleKey key)
        {
            ConsoleKey input;
            do
            {
                input = Console.ReadKey().Key;
            }
            while ( ! IsArrowkey(input));
            key = input;
        }
        private Boolean IsArrowkey(ConsoleKey key)
        {
            var KeyCode = (int) key;
            var min = 37;
            var max = 40;
            return TestRange(KeyCode, min, max);
        }
        private bool TestRange(int numberToCheck, int bottom, int top)
        {
            return (numberToCheck >= bottom && numberToCheck <= top);
        }
    }
}
