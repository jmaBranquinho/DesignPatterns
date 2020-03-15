namespace AbstractFactory
{
    internal class ModernFactory : AnimalFactory
    {

        public override Carnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Chicken();
        }
    }
}