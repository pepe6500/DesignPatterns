using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    class KickboardAdapter : Car
    {
        Kickboard kickboard;

        public KickboardAdapter(Kickboard kickboard)
        {
            this.kickboard = kickboard;
        }

        public override void EngineStart()
        {
            kickboard.PowerOn();
        }

        public override void EngineOff()
        {
            kickboard.PowerOff();
        }

        public override void DoorOpen()
        {
            Console.WriteLine("킥보드에는 문이 없습니다.");
        }
    }
}
