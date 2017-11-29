using Store.Marketing.MarketingFacadeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingRepository
    {
    class MockCampaignRepository : ICampaignRepository
        {
        ICampaign instance = null;

        public void Delete(int campaignId)
            {
            return;
            }

        public ICampaign Find(int campaignId)
            {
            if (null != instance)
                return instance;
            return null;
            }

        public int Save(ICampaign campaign)
            {
            instance = campaign;
            return 1;
            }

        public void Update(int campaignId, ICampaign campaign)
            {
            return;
            }
        }
    }
