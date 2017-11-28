namespace Store.Sales.SalesController
    {
    interface ISalesController
        {
        int RegisterCustomer(string name, string surname, string email);
        int PlaceOrder(string phoneName, int customerId);
        int CancelOrder(int orderId);
        }
    }
