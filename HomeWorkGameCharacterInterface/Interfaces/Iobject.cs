using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface
{
    public interface Iobject
    {
         public abstract string Name { get; }
         bool Equipped { get; set; }
         public abstract void PrintStatus();
    }
}
