using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputMapper
    {
        public static Directions GetInputDirection()
        {
            var handler = new InputHandler();
            switch (handler.GetArrowkeyInput())
            {
                case ConsoleKey.UpArrow:
                    return Directions.Up;
                case ConsoleKey.DownArrow:
                    return Directions.Down;
                case ConsoleKey.LeftArrow:
                    return Directions.Left;
                case ConsoleKey.RightArrow:
                    return Directions.Right;
                default:
                    return 0; // Live dangerously by default.
            }
        }
    }
}