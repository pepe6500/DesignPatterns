using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class Tea : CaffeinBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("차를 우립니다.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("차에 레몬 추가.");
        }
    }
}
