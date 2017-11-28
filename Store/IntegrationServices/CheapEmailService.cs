using Store.Sales.SalesFacadeService;
using System;

namespace Store.IntegrationServices
    {
    class CheapEmailService : IEmailSender
        {
        public void SendEmail(string to, string body)
            {
            Console.WriteLine("Sending email to: " + to + "\n" +
                "Message:" + body);
            Console.WriteLine("Email might not reach destination. Try using other services.");
            }
        }
    }
