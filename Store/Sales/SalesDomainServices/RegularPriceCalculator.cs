using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesDomainServices
    {
    public class RegularPriceCalculator : IOrderPriceCalculator
        {
        public int CalculatePrice(ICustomer customer)
            {
            int basePrice = 100;

            // maybe customer deserves a discount
            if (customer.ShouldGetDiscount())
                basePrice = (int)(basePrice * 0.76);

            return basePrice;
            }
        }
    }
