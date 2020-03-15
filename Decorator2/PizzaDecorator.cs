using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;

        public PizzaDecorator(IPizza newPizza)
        {
            _pizza = newPizza;
        }

        public string BakePizza()
        {
            return _pizza.BakePizza();
        }
    }
}
