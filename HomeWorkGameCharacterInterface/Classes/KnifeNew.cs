using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HomeWorkGameCharacterInterface.Abstracts;

namespace HomeWorkGameCharacterInterface.Classes
{
    class KnifeNew : Knife
    {
        public KnifeNew() : base ("New knife", 100) { }
        public override string ToString() => Name;
        public override void PrintStatus()
        {
            //Console.WriteLine($"=={this}==");
            Console.WriteLine($"==Durability: {Durability}");
            Console.WriteLine($"==Protection: {Damage}");
            if (Equipped) Console.WriteLine("==Equipped");
            else Console.WriteLine("==Uneqipped");
        }

    }
}
