namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message, int campaignId)
            {
            return new RadioAdvertisment(message, campaignId);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            return new RadioCampaign(type, length);
            }
        }
    }
