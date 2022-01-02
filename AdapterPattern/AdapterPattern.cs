using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.AdapterPattern
{
    public class AdapterPattern
    {
        public void main()
        {
            Car car1 = new Car();
            Car car2 = new KickboardAdapter(new Kickboard());

            car1.EngineStart();
            car1.DoorOpen();
            car1.EngineOff();

            car2.EngineStart();
            car2.DoorOpen();
            car2.EngineOff();
        }
    }
}
