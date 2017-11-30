using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesRepository
    {
    public interface ICustomerRepository
        {
        int Save(ICustomer customer);
        ICustomer Find(int customerId);
        void Update(int customerId, ICustomer customer);
        void Delete(int customerId);
        }
    }
