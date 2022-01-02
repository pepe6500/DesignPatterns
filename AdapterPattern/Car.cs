using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    class Car
    {
        public virtual void EngineStart()
        {
            Console.WriteLine("시동을 걸었습니다.");
        }

        public virtual void EngineOff()
        {
            Console.WriteLine("시동을 껐습니다.");
        }

        public virtual void DoorOpen()
        {
            Console.WriteLine("문을 열었습니다.");
        }
    }
}
