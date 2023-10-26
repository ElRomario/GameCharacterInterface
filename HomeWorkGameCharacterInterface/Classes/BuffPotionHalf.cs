using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;

namespace HomeWorkGameCharacterInterface.Classes
{
    class BuffPotionHalf : BuffPotion
    {
        public BuffPotionHalf() : base("Half of Buff potion") { }
        public override void Effect()
        {
            Console.WriteLine("Gain +15 strength!");
        }
        public override string ToString() => Name;

        public override void PrintStatus()
        {
            //Console.WriteLine($"=={this}==");
            if (Equipped) Console.WriteLine("==Equipped");
            else Console.WriteLine("==Uneqipped");
            Console.Write("==Effect: "); Effect();
        }

    }
}
