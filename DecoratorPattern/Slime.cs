using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public class Slime : Monster
    {
        public Slime()
        {
        }

        public override int AttackDMG()
        {
            return 2;
        }

        public override string GetName()
        {
            return "슬라임입니다.";
        }
    }
}
