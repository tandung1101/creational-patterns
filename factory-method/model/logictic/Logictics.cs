using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factory_method.model.logictic
{
    abstract class Logictics
    {
        public void PlanDelivery()
        {
            Transport transport = CreateTransport();
            transport.Deliver();
        }
        public abstract Transport CreateTransport();
    }
}
