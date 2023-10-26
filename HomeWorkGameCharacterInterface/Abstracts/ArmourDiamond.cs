using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface.Abstracts
{
   abstract public class ArmourDiamond : Iarmour
    {
        public int Durability { get;  }
        public int Protection { get;  } = 50;
        public string Name { get;  }
        public bool Equipped { get; set; }
        public abstract void PrintStatus();

        public ArmourDiamond(string name, int durablilty)
        {
            Name = name;
            Durability = durablilty;
            Equipped = false;

        }
    }
}
