using Store.Sales.SalesDomainEntities;
using System;

namespace Store.Sales.SalesDomainServices
    {
    public class BigSalePriceCalculator : IOrderPriceCalculator
        {
        public int CalculatePrice(ICustomer customer)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Calculating order price");
            int basePrice = 100;

            // apply sale discount
            double discount = new Random().Next(20, 51) / 100;
            basePrice = (int)(basePrice * (1 - discount));

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
