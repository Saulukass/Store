namespace Store.Marketing.MarketingDomainEntities
    {
    public interface IMarketingFactory
        {
        IAdvertisment CreateAdvertisment(string message);
        ICampaign CreateCampaign(int length, string type);
        }
    }
