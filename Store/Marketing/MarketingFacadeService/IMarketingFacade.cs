namespace Store.Marketing.MarketingFacadeService
    {
    public interface IMarketingFacade
        {
        int AddAdvertisment(int campaignId, string message);
        int AddCampaign(int length, string type);
        int CancelAdvertisment(int advertismentId);
        }
    }
