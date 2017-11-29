namespace Store.Production.ProductionDomainEntities
    {
    public interface IProductionFactory
        {
        IPhone CreatePhone(string phoneName);
        IWarehouse CreateWarehouse(string location, int capacity);
        }
    }
