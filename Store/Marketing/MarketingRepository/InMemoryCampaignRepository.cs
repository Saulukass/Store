using Store.Marketing.MarketingFacadeService;
using System.Collections.Generic;
using Store.Marketing.MarketingDomainEntities;
using System;

namespace Store.Marketing.MarketingRepository
    {
    public class InMemoryCampaignRepository : ICampaignRepository
        {
        Dictionary<int, ICampaign> storage;
        static int id = 0;

        public InMemoryCampaignRepository()
            {
            storage = new Dictionary<int, ICampaign>();
            }

        public void Delete(int campaignId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting campaign");
            storage.Remove(campaignId);
            }

        public ICampaign Find(int campaignId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for campaign");
            if (storage.ContainsKey(campaignId))
                return storage[campaignId];
            return null;
            }

        public int Save(ICampaign campaign)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving campaign");
            int newId = ++id;
            storage.Add(newId, campaign);
            return newId;
            }

        public void Update(int campaignId, ICampaign campaign)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating campaign");
            if (storage.ContainsKey(campaignId))
                storage[campaignId] = campaign;
            }
        }
    }
