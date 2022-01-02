using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    class Kickboard
    {
        public void PowerOn()
        {
            Console.WriteLine("전원을 켰습니다.");
        }

        public void PowerOff()
        {
            Console.WriteLine("전원을 껐습니다.");
        }
    }
}
