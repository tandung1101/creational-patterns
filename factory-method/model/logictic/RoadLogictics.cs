using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.model.logictic
{
    class RoadLogictics : Logictics
    {
        public override Transport CreateTransport()
        {
            Truck result = new Truck();
            return result;
        }
    }
}
