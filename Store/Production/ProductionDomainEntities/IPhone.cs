namespace Store.Production.ProductionDomainEntities
    {
    public interface IPhone
        {
        string PhoneName { get; set; }
        int Popularity { get; }
        bool IsSupportedByLocalCustomers();
        }
    }
