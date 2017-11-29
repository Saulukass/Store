namespace Store.Marketing.MarketingDomainEntities
    {
    interface IMarketingFactory
        {
        IAdvertisment CreateAdvertisment(string message);
        ICampaign CreateCampaign(int length, string type);
        }
    }
