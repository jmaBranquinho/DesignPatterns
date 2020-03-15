using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class BarbecuePizza : PizzaDecorator, IPizza
    {
        private IPizza _pizza;

        public BarbecuePizza(IPizza newPizza) : base(newPizza)
        {
            _pizza = newPizza;
        }

        public string BakePizza()
        {
            return $"{_pizza.BakePizza()} with beef, onion and barbecue sauce";
        }
    }
}
