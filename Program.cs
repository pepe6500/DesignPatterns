using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.StrategyPattern;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ObserverPattern.ObserverPattern observerPattern = new ObserverPattern.ObserverPattern();
            observerPattern.main();

            Console.ReadKey();
        }
    }
}
