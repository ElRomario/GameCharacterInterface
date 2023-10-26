using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;

namespace HomeWorkGameCharacterInterface.Classes
{
    class SwordNew : Sword
    {
        public SwordNew() : base("New Sword", 100) { }
        public override string ToString()=>Name;

        public override void PrintStatus()
        {
            //Console.WriteLine($"=={this}==");
            Console.WriteLine($"==Damage: {Durability}");
            Console.WriteLine($"==Durability: {Damage}");
            if (Equipped) Console.WriteLine("==Equipped");
            else Console.WriteLine("==Uneqipped");
        }

    }
}
