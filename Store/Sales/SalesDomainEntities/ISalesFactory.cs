﻿namespace Store.Sales.SalesDomainEntities
    {
    interface ISalesFactory
        {
        ICustomer CreateCustomer(string name, string surname, string email);
        IOrder CreateOrder(string phoneName, int customerId, int price);
        }
    }
