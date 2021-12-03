using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern
{
    public class Tackle : AttackBehavior
    {
        public void Attack()
        {
            Console.WriteLine("몸통박치기!");
        }
    }
}
