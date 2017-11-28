namespace Store.Marketing.MarketingDomainEntities
    {
    interface IMarketingFactory
        {
        IAdvertisment CreateAdvertisment(string message, int campaignId);
        ICampaign CreateCampaign(int length, string type);
        }
    }
