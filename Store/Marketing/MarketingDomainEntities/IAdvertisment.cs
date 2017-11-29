namespace Store.Marketing.MarketingDomainEntities
    {
    interface IAdvertisment
        {
        string Message { get; set; }

        bool HasGraphics();
        void ApplyNewCampaign(ICampaign campaign);
        int GetDuration();
        }
    }
