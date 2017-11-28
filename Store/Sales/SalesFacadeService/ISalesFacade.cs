namespace Store.Sales.SalesFacadeService
    {
    interface ISalesFacade
        {
        int RegisterCustomer(string name, string surname, string email);
        int PalceOrder(string phoneName, int customerId);
        int CancelOrder(int orderId);
        }
    }
