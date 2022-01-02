using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class Monster
    {
        public Monster()
        {
        }

        public abstract int AttackDMG();

        public abstract string GetName();
    }
}
