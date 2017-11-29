namespace Store.Sales.SalesDomainEntities
    {
    public interface IOrder
        {
        string PhoneName { get; set; }
        int CustomerId { get; set; }
        int Price { get; set; }
        }
    }
