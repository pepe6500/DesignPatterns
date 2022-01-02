using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public abstract class CaffeinBeverage
    {
        public void PrepaereRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            AddCondiments();
        }

        protected abstract void Brew();

        protected abstract void AddCondiments();

        void BoilWater()
        {
            Console.WriteLine("물을 끓입니다.");
        }

        void PourInCup()
        {
            Console.WriteLine("컵에 담습니다.");
        }
    }
}
