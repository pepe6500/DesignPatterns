using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class ListIterator <T> : Iterator
    {
        List<T> list = new List<T>();
        int position = 0;
        public ListIterator(List<T> list)
        {
            this.list = list;
        }

        public bool HasNext()
        {
            return list.Count > position && list[position] != null;
        }

        public object Next()
        {
            return list[++position - 1];
        }
    }
}
