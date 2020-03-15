using System;
using System.Collections.Generic;
using System.Threading;

namespace ObserverPattern
{
    public class Earthquake : IObservable
    {
        public long RichterIntensity{ get; set; }
        public bool IsShaking => RichterIntensity > 0;

        private List<IObserver> _observers;

        public Earthquake()
        {
            _observers = new List<IObserver>();
            RichterIntensity = 0;
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            if(IsShaking)
            {
                Console.WriteLine($"A new earthquake has started with intensity of {RichterIntensity}");
            }

            _observers.ForEach(observer => observer.Update(this));
        }

        public void Shake()
        {
            var random = new Random();

            RichterIntensity = random.Next(0, 10);

            Thread.Sleep(random.Next(0, 20));

            Notify();
        }
    }
}
