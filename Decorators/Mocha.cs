using Decorator.CoffeeShop.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.CoffeeShop.Decorators
{
    public class Mocha : CondimentDecorator
    {
        public Beverage beverage;

        public Mocha(Beverage _beverage)
        {
            this.beverage = _beverage;
        }

        public override string GetDescription()
        {
            return beverage.description + ", " + this.GetType().Name.ToString();
        }

        public override double cost()
        {
            return .20 + beverage.cost();
        }
    }
}
