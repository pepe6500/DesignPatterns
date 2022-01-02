using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class MenuItem : MenuComponent
    {
        string name;

        public MenuItem(string name)
        {
            this.name = name;
        }

        public void AddComponent(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine(name);
        }

        public void RemoveComponent(MenuComponent menuComponent)
        {
            throw new NotImplementedException();
        }
    }
}
