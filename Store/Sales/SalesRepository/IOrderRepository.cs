﻿using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesRepository
    {
    public interface IOrderRepository
        {
        int Save(IOrder order);
        IOrder Find(int orderId);
        void Update(int orderId, IOrder order);
        void Delete(int orderId);
        }
    }
