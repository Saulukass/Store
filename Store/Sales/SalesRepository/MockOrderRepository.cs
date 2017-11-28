using Store.Sales.SalesFacadeService;
using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesRepository
    {
    class MockOrderRepository : IOrderRepository
        {
        IOrder instance;
        public void Delete(int id)
            {
            return;
            }

        public IOrder FindOrder(int id)
            {
            if (null != instance)
                return instance;

            return null;
            }

        public int Save(IOrder order)
            {
            instance = order;
            return 1;
            }

        public void Update(int id, IOrder order)
            {
            return;
            }
        }
    }
