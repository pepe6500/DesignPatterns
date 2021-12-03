using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public abstract class Monster
    {
        protected AttackBehavior attackBehavior;

        public Monster()
        {
        }

        public void SetAttackBehavior(AttackBehavior attackBehavior)
        {
            this.attackBehavior = attackBehavior;
        }

        public void Attack()
        {
            attackBehavior.Attack();
        }

        public abstract void ShowName();
    }
}
