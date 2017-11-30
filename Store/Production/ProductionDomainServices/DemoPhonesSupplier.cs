using System;
using Store.Production.ProductionDomainEntities;

namespace Store.Production.ProductionDomainServices
    {
    public class DemoPhonesSupplier : IPhoneSupplier
        {
        IPhonesSuppliedListener phonesSuppliedListener;

        public void SupplyPhonesToWarehouse(IPhone phone, IWarehouse warehouse)
            {
            warehouse.StorePhone(phone, 10);

            if (null != phonesSuppliedListener)
                {
                phonesSuppliedListener.OnPhonesSupplied("10 demo phones: " + phone.PhoneName +
                    " was stored in warehouse at: " + warehouse.Location);
                }
            }

        public void RegisterPhonesSuppliedListener(IPhonesSuppliedListener listener)
            {
            phonesSuppliedListener = listener;
            }
        }
    }
