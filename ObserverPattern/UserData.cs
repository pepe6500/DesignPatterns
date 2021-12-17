using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class UserData : Observable
    {
        List<Observer> observers = new List<Observer>();
        bool isChanged = false;

        string userName;
        string userEmail;

        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }

        public void deleteObserver(Observer observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            if (isChanged)
                observers.ForEach(o => o.Update(this, null));
        }

        public void setChanged()
        {
            isChanged = true;
        }

        public void ChangedUserData()
        {
            setChanged();
            notifyObservers();
        }

        public void SetUserData(string userName, string userEmail)
        {
            this.userName = userName;
            this.userEmail = userEmail;
            ChangedUserData();
        }

        public string GetUserName()
        {
            return userName;
        }

        public string GetUserEmail()
        {
            return userEmail;
        }
    }
}
