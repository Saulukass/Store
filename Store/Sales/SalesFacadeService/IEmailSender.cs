namespace Store.Sales.SalesFacadeService
    {
    interface IEmailSender
        {
        void SendEmail(string to, string body);
        }
    }
