﻿using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesFacadeService
    {
    interface IOrderRepository
        {
        int Save(IOrder order);
        IOrder FindOrder(int orderId);
        void Update(int orderId, IOrder order);
        void Delete(int orderId);
        }
    }