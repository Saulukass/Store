﻿namespace Store.Sales.SalesDomainEntities
    {
    public class LoyalCustomer : ICustomer
        {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public LoyalCustomer(string name, string surname, string email)
            {
            Name = name;
            Surname = surname;
            Email = email;
            }

        public bool ShouldGetDiscount()
            {
            return true;
            }
        }
    }
