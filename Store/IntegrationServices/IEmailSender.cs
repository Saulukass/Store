namespace Store.IntegrationServices
    {
    public interface IEmailSender
        {
        void SendEmail(string to, string body);
        }
    }
