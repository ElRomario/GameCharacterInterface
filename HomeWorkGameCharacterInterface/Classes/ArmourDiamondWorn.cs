using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;

namespace HomeWorkGameCharacterInterface.Classes
{
    class ArmourDiamondWorn : ArmourDiamond 
    {
        public ArmourDiamondWorn() : base ("Worn Diamond Armour", 25) { }
        public override string ToString() =>Name;
        public override void PrintStatus()
        {
            //Console.WriteLine($"=={this}==");
            Console.WriteLine($"==Durability: {Durability}");
            Console.WriteLine($"==Protection: {Protection}");
            if (Equipped) Console.WriteLine("==Equipped");
            else Console.WriteLine("==Uneqipped");
        }

    }
}
