namespace AbstractFactory
{
    public class Velociraptor : Carnivore
    {
        public Velociraptor()
        {
            Name = nameof(Velociraptor);
        }

        public override void Eat(Herbivore animal)
        {
            System.Console.WriteLine($"{nameof(Velociraptor)} is running");
            base.Eat(animal);
        }
    }
}