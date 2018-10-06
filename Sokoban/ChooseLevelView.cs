using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class ChooseLevelView : IRenderable
    {
        public void Render()
        {
            Console.WriteLine("Welkom bij sokoban.");
            Console.WriteLine(" ");
            Console.WriteLine("Kies een level:");
            for(short i = 1; i <= 6; i++)
                Console.WriteLine("{0}: level {0}", i);
            Console.WriteLine(" ");
            Console.WriteLine("Type een nummer om een level te starten.");
        }
    }
}
