namespace Store.Production.ProductionDomainEntities
    {
    interface IPhone
        {
        string PhoneName { get; set; }
        int Popularity { get; }
        bool IsSupportedByLocalCustomers();
        }
    }
