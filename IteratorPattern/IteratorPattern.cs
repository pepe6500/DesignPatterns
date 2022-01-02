using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class IteratorPattern // + 컴포지트 패턴
    {
        public void main()
        {
            DinerMenu dinerMenu = new DinerMenu();
            dinerMenu.PrintAllMenu();
        }
    }
}
