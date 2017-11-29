using Store.Sales.SalesDomainEntities;

namespace Store.Sales.SalesDomainServices
    {
    public interface IOrderPriceCalculator
        {
        int CalculatePrice(ICustomer customer);
        }
    }
