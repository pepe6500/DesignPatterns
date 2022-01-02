using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class TemplateMethodPattern
    {
        public void main()
        {
            CaffeinBeverage caffeinBeverage = new Tea();
            caffeinBeverage.PrepaereRecipe();

            caffeinBeverage = new Coffee();
            caffeinBeverage.PrepaereRecipe();
        }
    }
}
