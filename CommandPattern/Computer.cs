using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class Computer
    {
        public void ComputerOn()
        {
            Console.WriteLine("컴퓨터가 켜졌습니다.");
        }

        public void ComputerOff()
        {
            Console.WriteLine("컴퓨터가 꺼졌습니다.");
        }
    }
}
