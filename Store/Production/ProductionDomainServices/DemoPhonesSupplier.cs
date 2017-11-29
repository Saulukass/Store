using System;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    public class DemoPhonesSupplier : IPhoneSupplier
        {
        public void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Storing 10 " + phone.PhoneName + " phones at" + warehouse.Location);
            warehouse.StorePhone(phone, 10);
            }
        }
    }
