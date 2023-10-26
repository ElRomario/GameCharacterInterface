using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface
{
    public interface Iweapon : Iobject
    {
       abstract public int Damage { get; set; }
       abstract public int Durability { get; set; }
    }
}
