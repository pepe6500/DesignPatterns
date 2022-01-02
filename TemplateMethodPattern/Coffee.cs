using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.TemplateMethodPattern
{
    public class Coffee : CaffeinBeverage
    {
        protected override void Brew()
        {
            Console.WriteLine("커피를 내립니다.");
        }

        protected override void AddCondiments()
        {
            Console.WriteLine("커피에 설탕 추가.");
        }
    }
}
