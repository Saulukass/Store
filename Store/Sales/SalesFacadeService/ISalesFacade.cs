namespace Store.Sales.SalesFacadeService
    {
    public interface ISalesFacade
        {
        int RegisterCustomer(string name, string surname, string email);
        int PalceOrder(string phoneName, int customerId);
        int CancelOrder(int orderId);
        }
    }
