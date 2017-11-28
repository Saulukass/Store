namespace Store.Production.ProductionDomainEntities
    {
    interface IProductionFactory
        {
        IPhone CreatePhone(string phoneName);
        IWarehouse CreateWarehouse(string location, int capacity);
        }
    }
