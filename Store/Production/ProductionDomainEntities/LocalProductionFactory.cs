namespace Store.Production.ProductionDomainEntities
    {
    class LocalProductionFactory : IProductionFactory
        {
        public IPhone CreatePhone(string phoneName)
            {
            return new LocalPhone(phoneName);
            }

        public IWarehouse CreateWarehouse(string location, int capacity)
            {
            return new LocalWarehouse(location, capacity);
            }
        }
    }
