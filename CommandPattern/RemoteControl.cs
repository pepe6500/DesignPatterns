using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    public class RemoteControl
    {
        Command[] onCommand;
        Command[] offCommand;

        Command undoCommand = new NullCommand();

        public RemoteControl()
        {
            Light light = new Light();
            Computer computer = new Computer();

            onCommand = new Command[2];
            offCommand = new Command[2];

            onCommand[0] = new LightOnCommand(light);
            onCommand[1] = new ComputerOnCommand(computer);
            
            offCommand[0] = new LightOffCommand(light);
            offCommand[1] = new ComputerOffCommand(computer);
        }

        public void PushOnButton(int index)
        {
            onCommand[index].Execute();
            undoCommand = onCommand[index];
        }

        public void PushOffButton(int index)
        {
            offCommand[index].Execute();
            undoCommand = offCommand[index];
        }

        public void PushUndoButton()
        {
            undoCommand.Undo();
        }
    }
}
