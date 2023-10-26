using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkGameCharacterInterface
{
    public interface Iarmour : Iobject
    {
        abstract public int Durability { get;  }
        abstract public int Protection { get;  }
        
    }
}
