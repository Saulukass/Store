namespace Store.Sales.SalesDomainEntities
    {
    class DiscountedOrder : IOrder
        {
        public string PhoneName { get; set; }
        public int CustomerId { get; set; }
        public int Price { get; set; }

        public DiscountedOrder(string phoneName, int customerId, int price)
            {
            PhoneName = phoneName;
            CustomerId = customerId;
            Price = price;
            }

        }
    }
