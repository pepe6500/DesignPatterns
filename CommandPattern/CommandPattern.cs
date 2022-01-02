using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    class CommandPattern
    {
        public void main()
        {
            RemoteControl remoteControl = new RemoteControl();
            remoteControl.PushOnButton(1);

            remoteControl.PushOffButton(0);
            remoteControl.PushUndoButton();
        }
    }
}
