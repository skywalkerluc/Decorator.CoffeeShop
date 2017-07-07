using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.CoffeeShop.Domain
{
    public abstract class Beverage 
    {
        public string description = "Unknown beverage";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
