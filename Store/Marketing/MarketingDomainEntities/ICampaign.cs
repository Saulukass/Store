namespace Store.Marketing.MarketingDomainEntities
    {
    public interface ICampaign
        {
        string Type { get; set; }
        int AdLength { get; set; }

        bool ShouldExtendAdvertisment();
        }
    }
