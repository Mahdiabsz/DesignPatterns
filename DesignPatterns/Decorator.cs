using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    // base interface
    public interface IPizza
    {
        public string GetPizza();
    }
    // concrete implementation
    public class Pizza : IPizza
    {
        public string GetPizza()
        {
            return "Normal pizza";
        }
    }
    // base decorator
    public class PizzaDecorator : IPizza
    {
        private IPizza _pizza;
        public PizzaDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }

        public virtual string GetPizza()
        {
            return _pizza.GetPizza();
        }
    }
    // concrete decorator
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizza()
        {
            return base.GetPizza() + "\r\n with cheese";
        }
    }

    public class OnionDecorator : PizzaDecorator
    {
        public OnionDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizza()
        {
            return base.GetPizza() + "\r\n with onion";
        }
    }

    public class TomatoDecorator : PizzaDecorator
    {
        public TomatoDecorator(IPizza pizza) : base(pizza) { }

        public override string GetPizza()
        {
            return base.GetPizza() + "\r\n with tomato";
        }
    }
}
