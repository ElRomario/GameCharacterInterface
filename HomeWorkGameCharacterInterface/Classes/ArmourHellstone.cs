using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface.Abstracts
{
    class ArmourHellstone : Iarmour
    {
        public int Durability { get; } = 100000000;
        public int Protection { get; } = 100000000;
        public string Name { get; } = "HellStone Armour";
        public bool Equipped { get; set; }

        public override string ToString() => Name;
        public void PrintStatus()
        {
            //Console.WriteLine($"=={this}==");
            Console.WriteLine($"==Durability: {Durability}");
            Console.WriteLine($"==Protection: {Protection}");
            if (Equipped) Console.WriteLine("==Equipped");
            else Console.WriteLine("==Uneqipped");
        }

        public ArmourHellstone()
        {
            Equipped = false;
        }
        

    }
}
