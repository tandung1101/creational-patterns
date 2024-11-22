using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.model.logictic
{
    class SeaLogictics : Logictics
    {
        public override Transport CreateTransport()
        {
            Ship result = new Ship();
            return result;
        }
    }
}
