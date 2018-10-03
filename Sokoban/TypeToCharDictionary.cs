using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class TypeToCharDictionary
    {
        public Dictionary<Type, char> table = new Dictionary<Type, char>();
        public TypeToCharDictionary()
        {
            table.Add(typeof(Player), '@');
            table.Add(typeof(Box), 'O');
            table.Add(typeof(Wall), '#');
        }
    }
}