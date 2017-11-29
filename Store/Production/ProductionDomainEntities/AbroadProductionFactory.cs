using System;

namespace Store.Production.ProductionDomainEntities
    {
    public class AbroadProductionFactory : IProductionFactory
        {
        public IPhone CreatePhone(string phoneName)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating AbroadPhone");
            return new AbroadPhone(phoneName);
            }

        public IWarehouse CreateWarehouse(string location, int capacity)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating AbroadWarehouse");
            return new AbroadWarehouse(location, capacity);
            }
        }
    }
