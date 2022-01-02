using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.DecoratorPattern
{
    class DecoratorPattern
    {
        public void main()
        {
            Monster slime = new Sword(new Hat(new Slime()));
            Console.WriteLine(slime.GetName());
            Console.WriteLine("대미지는 " + slime.AttackDMG());
        }
    }
}
