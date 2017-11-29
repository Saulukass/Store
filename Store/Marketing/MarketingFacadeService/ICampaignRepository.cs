﻿using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingFacadeService
    {
    public interface ICampaignRepository
        {
        ICampaign Find(int campaignId);
        int Save(ICampaign campaign);
        void Update(int campaignId, ICampaign campaign);
        void Delete(int campaignId);
        }
    }
