using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    class SingletonPattern
    {
        public void main()
        {
            Singleton singleton_1 = Singleton.GetInstance();
            Singleton singleton_2 = Singleton.GetInstance();
            singleton_1.SetValue(10);
            Console.WriteLine(singleton_1.GetValue());
            Console.WriteLine(singleton_2.GetValue());
        }
    }
}
