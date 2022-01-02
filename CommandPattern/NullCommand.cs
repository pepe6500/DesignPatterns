using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.CommandPattern
{
    class NullCommand : Command
    {
        public void Execute()
        {
        }

        public void Undo()
        {
        }
    }
}
