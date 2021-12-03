using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class StrategyPattern
    {
        public void main()
        {
            Monster monster1 = new Zombie();
            Monster monster2 = new Slime();

            monster1.ShowName();
            monster1.Attack();
            monster2.ShowName();
            monster2.Attack();
            monster2.SetAttackBehavior(new Poison());
            Console.WriteLine("새로운 기술 독");
            monster2.Attack();
        }
    }
}
