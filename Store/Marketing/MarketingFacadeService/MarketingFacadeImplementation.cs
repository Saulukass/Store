using Store.Marketing.MarketingDomainEntities;
using Store.Marketing.MarketingDomainServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Marketing.MarketingFacadeService
    {
    class MarketingFacadeImplementation : IMarketingFacade
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
            // TODO
            return 1;
            }

        public int AddCampaign(int length, string type)
            {
            // TODO
            return 1;
            }

        public int CancelAdvertisment(int advertismentId)
            {
            // TODO
            return 1;
            }
        }
    }
