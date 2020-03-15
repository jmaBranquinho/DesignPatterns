using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class Person : IObserver
    {
        public string Name { get; set; }
        public bool IsPanicking { get; private set; }

        public virtual void Update(IObservable subject)
        {
            IsPanicking = (subject as Earthquake).IsShaking;

            if(IsPanicking)
            {
                Console.WriteLine($"{Name} is panicking!");
            }
        }
    }
}
