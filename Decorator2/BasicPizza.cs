using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator2
{
    public class BasicPizza : IPizza
    {
        public string BakePizza()
        {
            return "Basic Pizza";
        }
    }
}
