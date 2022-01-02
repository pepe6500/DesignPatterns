using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    class Light
    {
        public void LightOn()
        {
            Console.WriteLine("전등이 켜졌습니다.");
        }

        public void LightOff()
        {
            Console.WriteLine("전등이 꺼졌습니다.");
        }
    }
}
