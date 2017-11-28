using System;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    class DemoPhonesSupplier : IPhoneSupplier
        {
        public void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse)
            {
            warehouse.StorePhone(phone, 10);
            }
        }
    }
