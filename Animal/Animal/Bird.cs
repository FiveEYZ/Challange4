using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Bird : Animal
    {
        public Bird(string Name, bool HaveTail, bool IsDangerous) : base(Name, HaveTail, IsDangerous)
        {
        }
    }
}
