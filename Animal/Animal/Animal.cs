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
        private bool _haveTail { get; set; }
        private bool _isDangerous { get; set; }

        public Animal(string Name, bool HaveTail, bool IsDangerous)
        {
            Name = _name;
            HaveTail = _haveTail;
            IsDangerous = _isDangerous;
        }
        public string AnimalName()
        {
            return "Animal; " + _name + "have " + _haveTail + "and is " + _isDangerous;
        }
    }
}
