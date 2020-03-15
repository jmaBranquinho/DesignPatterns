using System;

namespace ObserverPattern
{
    class Program
    {
        //Observer Pattern
        //It provides a way to react to events happening in other objects without coupling to their classes.
        static void Main(string[] args)
        {
            var earthquake = new Earthquake();

            //first earthquake ever
            earthquake.Shake();

            //Bob and Daredevil are born
            Console.WriteLine("Bob and Daredevil were born");
            var bob = new Person
            {
                Name = "Bob"
            };
            var daredevil = new BravePerson
            {
                Name = "Daredevil"
            };

            earthquake.Attach(bob);
            earthquake.Attach(daredevil);

            //earthquake!!
            earthquake.Shake();

            //bob dies of heartattack
            Console.WriteLine("Bob dies of heartattack");
            earthquake.Detach(bob);

            //earthquake!! (pt 2)
            earthquake.Shake();

            Console.WriteLine("End of simulation...Press any key...");
            Console.ReadLine();
        }
    }
}
