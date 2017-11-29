using Store.Sales.SalesFacadeService;
using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesRepository
    {
    public class MockCustomerRepository : ICustomerRepository
        {
        ICustomer instance = null;

        public void Delete(int customerId)
            {
            return;
            }

        public ICustomer Find(int customerId)
            {
            if (null != instance)
                return instance;

            return null;
            }

        public int Save(ICustomer customer)
            {
            instance = customer;
            return 1;
            }

        public void Update(int customerId, ICustomer customer)
            {
            return;
            }
        }
    }
