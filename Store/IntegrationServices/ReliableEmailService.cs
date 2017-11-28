using Store.Sales.SalesFacadeService;
using System;

namespace Store.IntegrationServices
    {
    class ReliableEmailService : IEmailSender
        {
        public void SendEmail(string to, string body)
            {
            Console.WriteLine("Email send to: " + to + "\n" +
                "Message:" + body);
            Console.WriteLine("Email reliably reached destination.");
            }
        }
    }
