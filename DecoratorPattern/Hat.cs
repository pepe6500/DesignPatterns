using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class Hat : MonsterDecorator
    {
        Monster monster;
        public Hat(Monster monster)
        {
            this.monster = monster;
        }

        public override int AttackDMG()
        {
            return monster.AttackDMG() + 1;
        }

        public override string GetName()
        {
            return "모자 착용, " + monster.GetName();
        }
    }
}
