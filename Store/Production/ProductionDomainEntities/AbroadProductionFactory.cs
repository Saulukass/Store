namespace Store.Production.ProductionDomainEntities
    {
    class AbroadProductionFactory : IProductionFactory
        {
        public IPhone CreatePhone(string phoneName)
            {
            return new AbroadPhone(phoneName);
            }

        public IWarehouse CreateWarehouse(string location, int capacity)
            {
            return new AbroadWarehouse(location, capacity);
            }
        }
    }
