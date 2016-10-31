using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Animal
    {
        private string _name { get; set; }
        private bool _haveTail, _isDangerous;

        public Animal(string Name, bool HaveTail, bool IsDangerous)
        {
            Name = _name;
            HaveTail = _haveTail;
            IsDangerous = _isDangerous;
        }
        public string AnimalName()
        {
            return "This animal name is: " + _name + "\nit " + (_haveTail ? "does have tail" : "does not have a tail") + "\nit's " + (_isDangerous ? "dangerous!!" : "not dangerous :)");
        }
    }
}
