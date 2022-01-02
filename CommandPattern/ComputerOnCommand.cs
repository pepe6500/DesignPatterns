using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    class ComputerOnCommand : Command
    {
        Computer computer;

        public ComputerOnCommand(Computer computer)
        {
            this.computer = computer;
        }

        public void Execute()
        {
            computer.ComputerOn();
        }

        public void Undo()
        {
            computer.ComputerOff();
        }
    }
}
