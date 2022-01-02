using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton instance = new Singleton();

        int value = 0;

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            return instance;
        }

        public void SetValue(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return value;
        }
    }
}
