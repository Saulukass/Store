using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesFacadeService;
using System;
using System.Collections.Generic;

namespace Store.Sales.SalesRepository
    {
    public class InMemoryOrderRepository : IOrderRepository
        {
        Dictionary<int, IOrder> storage;
        static int id = 0;

        public InMemoryOrderRepository()
            {
            storage = new Dictionary<int, IOrder>();
            }

        public void Delete(int orderId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting order");
            storage.Remove(id);
            }

        public IOrder Find(int orderId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for order");
            if (storage.ContainsKey(orderId))
                return storage[id];
            return null;
            }

        public int Save(IOrder order)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving order");
            int newId = ++id;
            storage.Add(newId, order);
            return newId;
            }

        public void Update(int orderId, IOrder order)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating order");
            if (storage.ContainsKey(orderId))
                storage[id] = order;
            }
        }
    }
