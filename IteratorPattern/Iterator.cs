using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    interface Iterator
    {
        bool HasNext();
        object Next();
    }
}
