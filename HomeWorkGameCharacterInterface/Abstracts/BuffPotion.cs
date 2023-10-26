using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface.Abstracts
{
     abstract public class BuffPotion : Ipotion
    {
        public string Name { get;  }
        public bool Equipped { get; set; }
        public abstract void Effect();
        public abstract void PrintStatus();

        public BuffPotion(string name)
        {
            Name = name;
            Equipped = false;
        }
       
    }
}
