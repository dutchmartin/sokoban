using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputHandler
    {
        public ConsoleKey GetArrowkeyInput()
        {
            ConsoleKey input;
            do
            {
                input = Console.ReadKey().Key;
            }
            while ( ! IsArrowkey(input));
            return input;
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
        public int GetNummericInput(int min, int max)
        {
            int input;
            do
            {
                if (!Int32.TryParse(Console.ReadKey().KeyChar.ToString(), out input))
                {
                    continue;
                }
            }
            while (!TestRange(input, min, max));
            return input;
        }
    }
}
