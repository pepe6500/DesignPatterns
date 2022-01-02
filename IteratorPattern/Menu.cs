using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class Menu : MenuComponent
    {
        string name;
        List<MenuComponent> menuComponents = new List<MenuComponent>();

        public Menu(string name)
        {
            this.name = name;
        }

        public void AddComponent(MenuComponent menuComponent)
        {
            menuComponents.Add(menuComponent);
        }

        public void RemoveComponent(MenuComponent menuComponent)
        {
            menuComponents.Remove(menuComponent);
        }

        public void Print()
        {
            Console.WriteLine("\n    < " + name + " >");

            Iterator iterator = new ListIterator<MenuComponent>(menuComponents);
            while(iterator.HasNext())
            {
                ((MenuComponent)iterator.Next()).Print();
            }
        }
    }
}
