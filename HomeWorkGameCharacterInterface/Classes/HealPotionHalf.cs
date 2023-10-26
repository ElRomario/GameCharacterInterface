﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;

namespace HomeWorkGameCharacterInterface.Classes
{
    class HealPotionHalf : HealPotion
    {
        public HealPotionHalf() : base("Full Buff potion") { }
        public override void Effect()
        {
            Console.WriteLine("Restores health!");
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
