using Store.Marketing.MarketingDomainEntities;
using Store.Marketing.MarketingDomainServices;

namespace Store.Marketing.MarketingFacadeService
    {
    public class MarketingFacadeImplementation : IMarketingFacade
        {
        IAdvertismentRepository advertisments;
        ICampaignRepository campaigns;
        IAdvertismentFilter filter;
        IMarketingFactory marketingFactory;

        public MarketingFacadeImplementation(IAdvertismentRepository advertisments, ICampaignRepository campaigns, IAdvertismentFilter filter, IMarketingFactory marketingFactory)
            {
            this.advertisments = advertisments;
            this.campaigns = campaigns;
            this.filter = filter;
            this.marketingFactory = marketingFactory;
            }

        public int AddAdvertisment(int campaignId, string message)
            {
            ICampaign campaign = campaigns.Find(campaignId);
            if (null == campaign)
                return -1;

            IAdvertisment advertisment = marketingFactory.CreateAdvertisment(message);
            advertisment.ApplyNewCampaign(campaign);
            filter.FilterAdvertisment(advertisment);
            int advertismentId = advertisments.Save(advertisment);
            return 0;
            }

        public int AddCampaign(int length, string type)
            {
            ICampaign newCampaign = marketingFactory.CreateCampaign(length, type);
            int campaignId = campaigns.Save(newCampaign);
            return campaignId;
            }

        public int CancelAdvertisment(int advertismentId)
            {
            IAdvertisment toDelete = advertisments.Find(advertismentId);
            if (null == toDelete)
                return -1;

            advertisments.Delete(advertismentId);
            return advertismentId;
            }
        }
    }
