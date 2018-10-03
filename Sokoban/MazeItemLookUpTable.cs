using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class CharToTypeDictionary
    {
        public Dictionary<char, Type> table = new Dictionary<char, Type>();
        public CharToTypeDictionary()
        {
            table.Add('@', typeof(Player));
            table.Add('O', typeof(Box));
            table.Add('#', typeof(Wall));
            table.Add('.', null);
        }
    }
}