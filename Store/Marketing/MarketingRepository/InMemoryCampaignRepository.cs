using Store.Marketing.MarketingFacadeService;
using System.Collections.Generic;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingRepository
    {
    class InMemoryCampaignRepository : ICampaignRepository
        {
        Dictionary<int, ICampaign> storage;
        static int id = 0;

        public void Delete(int campaignId)
            {
            storage.Remove(campaignId);
            }

        public ICampaign Get(int campaignId)
            {
            return storage[campaignId];
            }

        public int Save(ICampaign campaign)
            {
            int newId = ++id;
            storage.Add(newId, campaign);
            return newId;
            }

        public void Update(int campaignId, ICampaign campaign)
            {
            storage[campaignId] = campaign;
            }
        }
    }
