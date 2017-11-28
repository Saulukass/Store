namespace Store.Sales.SalesDomainEntities
    {
    class RegularCustomer : ICustomer
        {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        public RegularCustomer(string name, string surname, string email)
            {
            Name = name;
            Surname = surname;
            Email = email;
            }

        public bool ShouldGetDiscount()
            {
            return false;
            }
        }
    }
