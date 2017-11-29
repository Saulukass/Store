using Store.Sales.SalesDomainEntities;
using Store.Sales.SalesFacadeService;
using System.Collections.Generic;

namespace Store.Sales.SalesRepository
    {
    class InMemoryCustomerRepository : ICustomerRepository
        {
        Dictionary<int, ICustomer> storage;
        static int id = 0;

        public InMemoryCustomerRepository()
            {
            storage = new Dictionary<int, ICustomer>();
            }

        public void Delete(int customerId)
            {
            storage.Remove(id);
            }

        public ICustomer Find(int customerId)
            {
            if (storage.ContainsKey(customerId))
                return storage[id];
            return null;
            }

        public int Save(ICustomer customer)
            {
            int newId = ++id;
            storage.Add(newId, customer);
            return newId;
            }

        public void Update(int customerId, ICustomer customer)
            {
            if (storage.ContainsKey(customerId))
                storage[id] = customer;
            }
        }
    }
