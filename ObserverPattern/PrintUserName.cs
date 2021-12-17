using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class PrintUserName : Observer
    {
        Observable observable;

        public PrintUserName(Observable observable)
        {
            this.observable = observable;
            observable.addObserver(this);
        }

        public void Update(Observable observable, string arg)
        {
            UserData userData = (UserData)observable;
            Console.WriteLine("유저의 이름은 " + userData.GetUserName());
        }
    }
}
