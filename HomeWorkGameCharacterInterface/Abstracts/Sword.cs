using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface
{
    abstract class Sword : Iobject
    {
        public string Name { get; set; }
        public bool Equipped { get; set; }
        public int Durability { get; set; }
        public int Damage { get; set; } = 60;
        public abstract void PrintStatus();

        protected Sword(string name, int durability)
        {
            Name = name;
            Durability = durability;
            Equipped = false;
        }
       
    }
}
