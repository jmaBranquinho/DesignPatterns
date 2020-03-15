namespace AbstractFactory
{
    public abstract class AnimalFactory
    {
        public abstract Herbivore CreateHerbivore();
        public abstract Carnivore CreateCarnivore();

    }
}
