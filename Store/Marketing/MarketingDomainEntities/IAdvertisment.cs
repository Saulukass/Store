namespace Store.Marketing.MarketingDomainEntities
    {
    interface IAdvertisment
        {
        string Message { get; set; }
        int CampaignId { get; set; }
        }
    }
