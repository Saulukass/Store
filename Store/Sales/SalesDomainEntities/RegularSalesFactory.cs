namespace Store.Sales.SalesDomainEntities
    {
    class RegularSalesFactory : ISalesFactory
        {
        public ICustomer CreateCustomer(string name, string surname, string email)
            {
            return new RegularCustomer(name, surname, email);
            }

        public IOrder CreateOrder(string phoneName, int customerId, int price)
            {
            return new RegularOrder(phoneName, customerId, price);
            }
        }
    }
