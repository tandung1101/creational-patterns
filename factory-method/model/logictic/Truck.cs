using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.model.logictic
{
    class Truck : Transport
    {
        public override void Deliver()
        {
            Console.WriteLine("Deliver by sea in a truck");
        }
    }
}
