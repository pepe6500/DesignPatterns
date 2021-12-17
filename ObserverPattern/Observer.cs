using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public interface Observer
    {
        void Update(Observable observable, string arg);
    }
}
