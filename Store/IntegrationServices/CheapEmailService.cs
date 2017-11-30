using System;

namespace Store.IntegrationServices
    {
    public class CheapEmailService : IEmailSender
        {
        public void SendEmail(string to, string body)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Sending email to: " + to + "\n" +
                "Message:" + body);
            Console.WriteLine("Email might not reach destination. Try using other services.");
            }
        }
    }
