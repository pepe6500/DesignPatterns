using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    class ComputerOffCommand : Command
    {
        Computer computer;

        public ComputerOffCommand(Computer computer)
        {
            this.computer = computer;
        }

        public void Execute()
        {
            computer.ComputerOff();
        }

        public void Undo()
        {
            computer.ComputerOn();
        }
    }
}
