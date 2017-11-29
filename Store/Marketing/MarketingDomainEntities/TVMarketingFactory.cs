using System;

namespace Store.Marketing.MarketingDomainEntities
    {
    public class TVMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating TVAdvertisment");
            return new TVAdvertisment(message);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating TVCampaign");
            return new TVCampaign(type, length);
            }
        }
    }
