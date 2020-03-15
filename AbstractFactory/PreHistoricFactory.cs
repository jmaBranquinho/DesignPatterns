namespace AbstractFactory
{
    public class PreHistoricFactory : AnimalFactory
    {
        public override Carnivore CreateCarnivore()
        {
            return new Velociraptor();
        }

        public override Herbivore CreateHerbivore()
        {
            return new Brontosaurus();
        }
    }
}
