using System;

namespace Store.Production.ProductionDomainEntities
    {
    public class AbroadPhone : IPhone
        {
        public string PhoneName { get; set; }

        public int Popularity { get; }

        public AbroadPhone(string phoneName)
            {
            PhoneName = phoneName;
            Popularity = new Random().Next(10, 101);
            }

        public bool IsSupportedByLocalCustomers()
            {
            return false;
            }
        }
    }
