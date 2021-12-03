using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Zombie : Monster
    {
        public Zombie()
        {
            attackBehavior = new Tackle();
        }

        public override void ShowName()
        {
            Console.WriteLine("좀비입니다.");
        }
    }
}
