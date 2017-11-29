namespace Store.Sales.SalesDomainEntities
    {
    public interface ISalesFactory
        {
        ICustomer CreateCustomer(string name, string surname, string email);
        IOrder CreateOrder(string phoneName, int customerId, int price);
        }
    }
