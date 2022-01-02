using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public class FactoryPattern
    {
        public void main()
        {
            PizzaFectory pizzaFectory = new SeoulPizzaFectory();
            pizzaFectory.OrderPizza("Cheese");
            pizzaFectory.OrderPizza("Chicken");
            pizzaFectory = new BusanPizzaFectory();
            pizzaFectory.OrderPizza("Cheese");
            pizzaFectory.OrderPizza("Chicken");
        }
    }
}
