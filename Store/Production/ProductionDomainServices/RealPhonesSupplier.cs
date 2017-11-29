using System;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    public class RealPhonesSupplier : IPhoneSupplier
        {
        IAdministratorNotifier administratorNotifier;

        public RealPhonesSupplier(IAdministratorNotifier administratorNotifier)
            {
            this.administratorNotifier = administratorNotifier;
            }

        public void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse)
            {
            int baseModelQuantity = 150;

            // Popularity of phone might increase production
            baseModelQuantity = (int)(baseModelQuantity * (1 + phone.Popularity / 100));

            // increase quantity becouse of local support;
            if (phone.IsSupportedByLocalCustomers())
                baseModelQuantity *= 2;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Supplying " + baseModelQuantity + " real production phones: " +
                phone.PhoneName + " at warehouse in " + warehouse.Location);
            warehouse.StorePhone(phone, baseModelQuantity);
            administratorNotifier.NotifyAdministrator("" + baseModelQuantity + " new phones: " + phone.PhoneName +
                " was stored in warehouse at: " + warehouse.Location);
            }
        }
    }
