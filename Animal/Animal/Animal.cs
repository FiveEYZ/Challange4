using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Animal
    {
        private string _name;
        private bool _haveTail, _isDangerous;

        public Animal(string Name, bool HaveTail, bool IsDangerous)
        {
            _name = Name;
            _haveTail = HaveTail;
            _isDangerous = IsDangerous;
        }

        public override string ToString()
        {
            return " name is: " + _name + "\n it " + (_haveTail ? "does have tail" : "does not have a tail") + "\n it's " + (_isDangerous ? "dangerous!!" : "not dangerous :)");
        }

        public virtual void DoSound()
        {
            //play animal sounds
        }
    }
}
