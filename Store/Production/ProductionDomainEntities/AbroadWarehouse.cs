using System.Collections.Generic;

namespace Store.Production.ProductionDomainEntities
    {
    class AbroadWarehouse : IWarehouse
        {
        public string Location { get; set; }
        public int Capacity { get; set; }

        public AbroadWarehouse(string location, int capacity)
            {
            Location = location;
            Capacity = 0;
            }

        public bool IsPhoneStored(IPhone phone)
            {
            return false;
            }

        public int GetPhoneQuantity(IPhone phone)
            {
            return 0;
            }

        public void StorePhone(IPhone phone, int quantity)
            {
            return;
            }

        public bool HasBoardersRestrictions()
            {
            return true;
            }
        }
    }
