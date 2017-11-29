namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioMarketingFactory : IMarketingFactory
        {
        public IAdvertisment CreateAdvertisment(string message)
            {
            return new RadioAdvertisment(message);
            }

        public ICampaign CreateCampaign(int length, string type)
            {
            return new RadioCampaign(type, length);
            }
        }
    }
