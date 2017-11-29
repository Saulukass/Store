namespace Store.Marketing.MarketingDomainEntities
    {
    public interface IAdvertisment
        {
        string Message { get; set; }

        bool HasGraphics();
        void ApplyNewCampaign(ICampaign campaign);
        int GetDuration();
        }
    }
