namespace Store.Marketing.MarketingDomainEntities
    {
    interface ICampaign
        {
        string Type { get; set; }
        int AdLength { get; set; }

        bool ShouldExtendAdvertisment();
        }
    }
