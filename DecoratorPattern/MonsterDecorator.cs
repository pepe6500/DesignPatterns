using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    public abstract class MonsterDecorator : Monster
    {
        public override abstract string GetName();
    }
}
