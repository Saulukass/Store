namespace Store.Marketing.MarketingFacadeService
    {
    interface IMarketingFacade
        {
        int AddAdvertisment(int campaignId, string message);
        int AddCampaign(int length, string type);
        int CancelAdvertisment(int advertismentId);
        }
    }
