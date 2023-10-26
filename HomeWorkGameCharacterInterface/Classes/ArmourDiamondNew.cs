using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;


namespace HomeWorkGameCharacterInterface.Classes
{
    class ArmourDiamondNew : ArmourDiamond
    {
       public ArmourDiamondNew() : base ("Diamond Armour", 50) { }
        public override string ToString()
        {
            return base.Name;
        }
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
