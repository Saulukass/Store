using System;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    class RealPhonesSupplier : IPhoneSupplier
        {
        public void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse)
            {
            int baseModelQuantity = 150;

            // Popularity of phone might increase production
            baseModelQuantity = (int)(baseModelQuantity * (1 + phone.Popularity / 100));

            // increase quantity becouse of local support;
            if (phone.IsSupportedByLocalCustomers())
                baseModelQuantity *= 2;

            warehouse.StorePhone(phone, baseModelQuantity);
            }
        }
    }
