using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class BravePerson : Person
    {
        private readonly long _tolerance = 5;

        public override void Update(IObservable subject)
        {
            if((subject as Earthquake).RichterIntensity > _tolerance)
            {
                base.Update(subject);
            }
        }
    }
}
