using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    class BusanPizzaFectory : PizzaFectory
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "Cheese")
                return new BusanCheesePizza();
            else if (type == "Chicken")
                return new BusanChickenPizza();
            return null;
        }
    }
}
