namespace AbstractFactory
{
    public class AnimalWorld
    {
        private Herbivore _herbivore;
        private Carnivore _carnivore;

        public AnimalWorld(AnimalFactory preHistoricFactory)
        {
            _herbivore = preHistoricFactory.CreateHerbivore();
            _carnivore = preHistoricFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}