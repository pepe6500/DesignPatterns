using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    interface MenuComponent
    {
        void Print();
        void AddComponent(MenuComponent menuComponent);
        void RemoveComponent(MenuComponent menuComponent);
    }
}
