using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public interface isPusher
    {
        bool Push(Directions direction, MatrixItem targetPushFinalLocation);
    }
}