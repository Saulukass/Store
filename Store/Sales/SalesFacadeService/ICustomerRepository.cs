using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesFacadeService
    {
    interface ICustomerRepository
        {
        int Save(ICustomer customer);
        ICustomer FindCutomer(int customerId);
        void Update(int customerId, ICustomer customer);
        void Delete(int customerId);
        }
    }
