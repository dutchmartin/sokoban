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
                    return Directions.North;
                case ConsoleKey.DownArrow:
                    return Directions.South;
                case ConsoleKey.LeftArrow:
                    return Directions.West;
                case ConsoleKey.RightArrow:
                    return Directions.East;
                default:
                    return 0; // Live dangerously by default.
            }
        }
    }
}