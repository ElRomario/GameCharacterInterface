using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface.Abstracts
{
    abstract class HealPotion : Ipotion
    {
            public string Name { get; }
            public bool Equipped { get; set; }
            public abstract void Effect();
            public abstract void PrintStatus();

        protected HealPotion(string name)
            {
                Name = name;
                Equipped = false;
            }
       

    }
}
