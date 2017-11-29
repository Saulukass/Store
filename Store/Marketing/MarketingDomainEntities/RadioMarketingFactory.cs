using System;

namespace Store.Marketing.MarketingDomainEntities
    {
    public class RadioMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating RadioAdvertisment");
            return new RadioAdvertisment(message);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating RadioCampaign");
            return new RadioCampaign(type, length);
            }
        }
    }
