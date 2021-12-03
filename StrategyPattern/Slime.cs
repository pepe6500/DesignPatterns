using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Slime : Monster
    {
        public Slime()
        {
            this.attackBehavior = new Tackle();
        }

        public override void ShowName()
        {
            Console.WriteLine("슬라임입니다.");
        }
    }
}
