using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.model
{
    class ConcreteCreatorB : Creator
    {
        public override Product FactoryMethod()
        {
            var product = new ConcreteProductB();
            return product;
        }
    }
}
