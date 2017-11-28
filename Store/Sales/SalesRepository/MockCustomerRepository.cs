﻿using Store.Sales.SalesFacadeService;
using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesRepository
    {
    class MockCustomerRepository : ICustomerRepository
        {
        ICustomer instance;
        public void Delete(int customerId)
            {
            return;
            }

        public ICustomer FindCutomer(int customerId)
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
