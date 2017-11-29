namespace Store.Sales.SalesDomainEntities
    {
    public class RegularOrder : IOrder
        {
        public string PhoneName { get; set; }
        public int CustomerId { get; set; }
        public int Price { get; set; }

        public RegularOrder(string phoneName, int cusmtomerId, int price)
            {
            PhoneName = phoneName;
            CustomerId = cusmtomerId;
            Price = price;
            }
        }
    }
