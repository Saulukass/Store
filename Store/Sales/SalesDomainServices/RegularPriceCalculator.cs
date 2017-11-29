using Store.Sales.SalesDomainEntities;
using System;

namespace Store.Sales.SalesDomainServices
    {
    public class RegularPriceCalculator : IOrderPriceCalculator
        {
        public int CalculatePrice(ICustomer customer)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Calculating order price");
            int basePrice = 100;

            // maybe customer deserves a discount
            if (customer.ShouldGetDiscount())
                {
                Console.WriteLine("[" + this.GetType().ToString() + "]" + " Applying discount for customer: " + customer.Name);
                basePrice = (int)(basePrice * 0.76);
                }

            return basePrice;
            }
        }
    }
