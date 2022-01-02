using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.IteratorPattern
{
    class DinerMenu
    {
        MenuComponent allMenu;

        public DinerMenu()
        {
            MenuComponent menuItems = new Menu("전체 메뉴");
            menuItems.AddComponent(new MenuItem("첫번째 점심 매뉴"));
            menuItems.AddComponent(new MenuItem("두번째 점심 매뉴"));
            menuItems.AddComponent(new MenuItem("세번째 점심 매뉴"));

            Menu menu = new Menu("스페셜 메뉴");
            menu.AddComponent(new MenuItem("첫번째 스페셜 매뉴"));
            menu.AddComponent(new MenuItem("두번째 스페셜 매뉴"));
            menuItems.AddComponent(menu);

            allMenu = menuItems;
        }

        public void PrintAllMenu()
        {
            allMenu.Print();
        }
    }
}
