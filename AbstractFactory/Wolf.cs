namespace AbstractFactory
{
    public class Wolf : Carnivore
    {
        public Wolf()
        {
            Name = nameof(Wolf);
        }

        public override void Eat(Herbivore animal)
        {
            System.Console.WriteLine($"{nameof(Wolf)} is hawling");
            base.Eat(animal);
        }
    }
}