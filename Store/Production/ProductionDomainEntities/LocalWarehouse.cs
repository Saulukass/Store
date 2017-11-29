using System.Collections.Generic;

namespace Store.Production.ProductionDomainEntities
    {
    class LocalWarehouse : IWarehouse
        {
        private Dictionary<IPhone, int> _phoneStorage;
        public string Location { get; set; }
        public int Capacity { get; set; }

        public LocalWarehouse(string location, int capacity)
            {
            Location = location;
            Capacity = capacity;
            _phoneStorage = new Dictionary<IPhone, int>();
            }

        public void StorePhone(IPhone phone, int quantity)
            {
            if (IsPhoneStored(phone))
                _phoneStorage[phone] += quantity;
            else
                _phoneStorage[phone] = quantity;
            }

        public bool IsPhoneStored(IPhone phone)
            {
            return _phoneStorage.ContainsKey(phone);
            }

        public int GetPhoneQuantity(IPhone phone)
            {
            if (IsPhoneStored(phone))
                return _phoneStorage[phone];
            return 0;
            }

        public bool HasBoardersRestrictions()
            {
            return false;
            }
        }
    }
