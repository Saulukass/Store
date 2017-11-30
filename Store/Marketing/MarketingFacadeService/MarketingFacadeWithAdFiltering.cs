using Store.Marketing.MarketingDomainEntities;
using Store.Marketing.MarketingDomainServices;
using Store.Marketing.MarketingRepository;
using System;

namespace Store.Marketing.MarketingFacadeService
    {
    public class MarketingFacadeWithAdFiltering : IMarketingFacade
        {
        IAdvertismentRepository advertisments;
        ICampaignRepository campaigns;
        IAdvertismentFilter filter;
        IMarketingFactory marketingFactory;

        public MarketingFacadeWithAdFiltering(IAdvertismentRepository advertisments, ICampaignRepository campaigns, IAdvertismentFilter filter, IMarketingFactory marketingFactory)
            {
            this.advertisments = advertisments;
            this.campaigns = campaigns;
            this.filter = filter;
            this.marketingFactory = marketingFactory;
            }

        public int AddAdvertisment(int campaignId, string message)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for campaign");
            ICampaign campaign = campaigns.Find(campaignId);
            if (null == campaign)
                return -1;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating Ad");
            IAdvertisment advertisment = marketingFactory.CreateAdvertisment(message);
            advertisment.ApplyNewCampaign(campaign);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Filtering Ad");
            filter.FilterAdvertisment(advertisment);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving Ad");
            int advertismentId = advertisments.Save(advertisment);
            return 0;
            }

        public int AddCampaign(int length, string type)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Creating new campaign");
            ICampaign newCampaign = marketingFactory.CreateCampaign(length, type);
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving campaign");
            int campaignId = campaigns.Save(newCampaign);
            return campaignId;
            }

        public int CancelAdvertisment(int advertismentId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for Ad");
            IAdvertisment toDelete = advertisments.Find(advertismentId);
            if (null == toDelete)
                return -1;

            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Ad found");
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting Ad");
            advertisments.Delete(advertismentId);
            return advertismentId;
            }
        }
    }
