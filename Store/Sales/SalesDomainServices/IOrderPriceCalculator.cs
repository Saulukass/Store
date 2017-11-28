using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesDomainServices
    {
    interface IOrderPriceCalculator
        {
        int CalculatePrice(ICustomer customer);
        }
    }
