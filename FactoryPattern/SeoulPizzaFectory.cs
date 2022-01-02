using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    class SeoulPizzaFectory : PizzaFectory
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type == "Cheese")
                return new SeoulCheesePizza();
            else if (type == "Chicken")
                return new SeoulChickenPizza();
            return null;
        }
    }
}
