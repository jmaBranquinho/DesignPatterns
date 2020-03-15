namespace AbstractFactory
{
    public abstract class Carnivore
    {
        public string Name { get; set; }

        public virtual void Eat(Herbivore animal)
        {
            System.Console.WriteLine($"{Name} is eating {animal.Name}");
        }
    }
}