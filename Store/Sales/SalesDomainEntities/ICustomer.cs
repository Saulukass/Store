namespace Store.Sales.SalesDomainEntities
    {
    public interface ICustomer
        {
        string Name { get; set; }
        string Surname { get; set; }
        string Email { get; set; }
        bool ShouldGetDiscount();
        }
    }
