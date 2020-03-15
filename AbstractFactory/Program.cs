using System;

namespace AbstractFactory
{
    class Program
    {
        //Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
        static void Main(string[] args)
        {
            AnimalWorld world;

            world = new AnimalWorld(new PreHistoricFactory());
            world.RunFoodChain();

            world = new AnimalWorld(new ModernFactory());
            world.RunFoodChain();
        }
    }
}
