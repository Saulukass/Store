using Store.Marketing.MarketingFacadeService;
using System.Collections.Generic;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingRepository
    {
    class InMemoryCampaignRepository : ICampaignRepository
        {
        Dictionary<int, ICampaign> storage;
        static int id = 0;

        public InMemoryCampaignRepository()
            {
            storage = new Dictionary<int, ICampaign>();
            }

        public void Delete(int campaignId)
            {
            storage.Remove(campaignId);
            }

        public ICampaign Find(int campaignId)
            {
            if (storage.ContainsKey(campaignId))
                return storage[campaignId];
            return null;
            }

        public int Save(ICampaign campaign)
            {
            int newId = ++id;
            storage.Add(newId, campaign);
            return newId;
            }

        public void Update(int campaignId, ICampaign campaign)
            {
            if (storage.ContainsKey(campaignId))
                storage[campaignId] = campaign;
            }
        }
    }
