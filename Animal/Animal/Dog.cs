﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Dog : Animal
    {
        public Dog(string Name, bool HaveTail, bool IsDangerous) 
            : base(Name, HaveTail, IsDangerous)
        {
            Name = "Niko";
            HaveTail = true;
            IsDangerous = false;
        }
    }
}
