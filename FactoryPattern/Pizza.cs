using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryPattern
{
    public abstract class Pizza
    {
        string name;
        string dough;
        string sauce;
        
        public Pizza(string name, string dough, string sauce)
        {
            this.name = name;
            this.dough = dough;
            this.sauce = sauce;
        }

        public void Prepare()
        {
            Console.WriteLine(name + " 준비중");
            Console.WriteLine("도우 :" + dough);
            Console.WriteLine("소스 :" + sauce);
            Console.WriteLine();
        }
    }
}
