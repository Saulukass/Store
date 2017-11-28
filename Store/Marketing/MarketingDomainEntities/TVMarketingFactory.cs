namespace Store.Marketing.MarketingDomainEntities
    {
    class TVMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message, int campaignId)
            {
            return new TVAdvertisment(message, campaignId);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            return new TVCampaign(type, length);
            }
        }
    }
