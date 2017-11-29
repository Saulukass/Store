using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesFacadeService;
using System.Collections.Generic;

namespace Store.Sales.SalesRepository
    {
    class InMemoryOrderRepository : IOrderRepository
        {
        Dictionary<int, IOrder> storage;
        static int id = 0;

        public InMemoryOrderRepository()
            {
            storage = new Dictionary<int, IOrder>();
            }

        public void Delete(int orderId)
            {
            storage.Remove(id);
            }

        public IOrder Find(int orderId)
            {
            if (storage.ContainsKey(orderId))
                return storage[id];
            return null;
            }

        public int Save(IOrder order)
            {
            int newId = ++id;
            storage.Add(newId, order);
            return newId;
            }

        public void Update(int orderId, IOrder order)
            {
            if (storage.ContainsKey(orderId))
                storage[id] = order;
            }
        }
    }
