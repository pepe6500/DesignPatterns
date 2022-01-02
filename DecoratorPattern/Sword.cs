using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class Sword : MonsterDecorator
    {
        Monster monster;
        public Sword(Monster monster)
        {
            this.monster = monster;
        }

        public override int AttackDMG()
        {
            return monster.AttackDMG() + 2;
        }

        public override string GetName()
        {
            return "검 착용, " + monster.GetName();
        }
    }
}
