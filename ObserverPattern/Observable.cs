using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public interface Observable
    {
        void addObserver(Observer observer);
        void deleteObserver(Observer observer);
        void notifyObservers();
        void setChanged();
    }
}
