using System;

namespace Store.Production.ProductionDomainEntities
    {
    class LocalPhone : IPhone
        {
        public string PhoneName { get; set; }

        public int Popularity { get; }

        public LocalPhone(string phoneName)
            {
            PhoneName = phoneName;
            }

        public bool IsSupportedByLocalCustomers()
            {
            return true;
            }
        }
    }
