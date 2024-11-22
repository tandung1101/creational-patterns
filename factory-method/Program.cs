using factory_method.model;
using factory_method.model.logictic;
using System;
namespace factory_method
{
    class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.RunCreatorProduct();
            program.RunLogictics();
        }

        public void RunCreatorProduct()
        {
            Creator[] creators = new Creator[2];
            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (Creator creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine($"Created {product.GetType().Name}");
            }
        }

        public void RunLogictics()
        {
            Logictics[] logictics = new Logictics[2];
            logictics[0] = new RoadLogictics();
            logictics[1] = new SeaLogictics();

            foreach (Logictics logictic in logictics)
            {
                Transport transport = logictic.CreateTransport();
                transport.Deliver();
            }
        }
    }
}