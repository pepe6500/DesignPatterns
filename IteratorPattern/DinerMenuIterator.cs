using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class DinerMenuIterator : Iterator
    {
        MenuComponent[] menuItems;
        int position = 0;

        public DinerMenuIterator(MenuComponent[] menuItems)
        {
            this.menuItems = menuItems;
        }

        public bool HasNext()
        {
            return menuItems.Length > position && menuItems[position] != null;
        }

        public object Next()
        {
            return menuItems[++position - 1];
        }
    }
}
