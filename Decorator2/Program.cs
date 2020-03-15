using System;

namespace Decorator2
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza barbecuePizza = new BarbecuePizza(new BasicPizza());
            Console.WriteLine(barbecuePizza.BakePizza());
        }
    }
}
