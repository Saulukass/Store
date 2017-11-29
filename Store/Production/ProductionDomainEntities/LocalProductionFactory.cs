using System;

namespace Store.Production.ProductionDomainEntities
    {
    public class LocalProductionFactory : IProductionFactory
        {
        public IPhone CreatePhone(string phoneName)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating LocalPhone");
            return new LocalPhone(phoneName);
            }

        public IWarehouse CreateWarehouse(string location, int capacity)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating LocalWarehouse");
            return new LocalWarehouse(location, capacity);
            }
        }
    }
