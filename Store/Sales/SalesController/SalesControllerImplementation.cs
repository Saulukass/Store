using Store.Sales.SalesFacadeService;

namespace Store.Sales.SalesController
    {
    public class SalesControllerImplementation : ISalesController
        {
        ISalesFacade salesFacade;

        public SalesControllerImplementation(ISalesFacade salesFacade)
            {
            this.salesFacade = salesFacade;
            }

        public int CancelOrder(int orderId)
            {
            return salesFacade.CancelOrder(orderId);
            }

        public int PlaceOrder(string phoneName, int customerId)
            {
            return salesFacade.PalceOrder(phoneName, customerId);
            }

        public int RegisterCustomer(string name, string surname, string email)
            {
            return salesFacade.RegisterCustomer(name, surname, email);
            }
        }
    }
