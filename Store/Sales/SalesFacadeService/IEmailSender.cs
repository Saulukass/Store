namespace Store.Sales.SalesFacadeService
    {
    public interface IEmailSender
        {
        void SendEmail(string to, string body);
        }
    }
