using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ObserverPattern
{
    public class ObserverPattern
    {
        public void main()
        {
            UserData userData = new UserData();
            PrintUserName printUserName = new PrintUserName(userData);
            PrintUserEmail printUserEmail = new PrintUserEmail(userData);

            userData.SetUserData("홍길동", "hong@email.com");
            userData.SetUserData("아무개", "amu@email.com");
            userData.deleteObserver(printUserEmail);
            userData.SetUserData("홍길순", "soon@email.com");
        }
    }
}
