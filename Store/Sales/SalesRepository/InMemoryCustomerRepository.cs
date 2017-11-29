using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesFacadeService;
using System;
using System.Collections.Generic;

namespace Store.Sales.SalesRepository
    {
    public class InMemoryCustomerRepository : ICustomerRepository
        {
        Dictionary<int, ICustomer> storage;
        static int id = 0;

        public InMemoryCustomerRepository()
            {
            storage = new Dictionary<int, ICustomer>();
            }

        public void Delete(int customerId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting customer");
            storage.Remove(id);
            }

        public ICustomer Find(int customerId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for customer");
            if (storage.ContainsKey(customerId))
                return storage[id];
            return null;
            }

        public int Save(ICustomer customer)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving customer");
            int newId = ++id;
            storage.Add(newId, customer);
            return newId;
            }

        public void Update(int customerId, ICustomer customer)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating customer");
            if (storage.ContainsKey(customerId))
                storage[id] = customer;
            }
        }
    }
