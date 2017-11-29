namespace Store.Marketing.MarketingDomainEntities
    {
    class TVMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message)
            {
            return new TVAdvertisment(message);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            return new TVCampaign(type, length);
            }
        }
    }
