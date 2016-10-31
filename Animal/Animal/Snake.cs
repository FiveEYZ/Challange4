using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Snake : Animal
    {
        public Snake(string Name, bool HaveTail, bool IsDangerous) 
            : base(Name, HaveTail, IsDangerous)
        {
        }
    }
}
