using Store.Marketing.MarketingFacadeService;
using Store.Marketing.MarketingDomainEntities;
using System.Collections.Generic;
using System;

namespace Store.Marketing.MarketingRepository
    {
    public class InMemoryAdvertismentRepository : IAdvertismentRepository
        {
        Dictionary<int, IAdvertisment> storage;
        static int id = 0;

        public InMemoryAdvertismentRepository()
            {
            storage = new Dictionary<int, IAdvertisment>();
            }

        public void Delete(int advertismentId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Deleting advertisment");
            storage.Remove(advertismentId);
            }

        public IAdvertisment Find(int advertismentId)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Looking for advertisment");
            if (storage.ContainsKey(advertismentId))
                return storage[advertismentId];
            return null;
            }

        public int Save(IAdvertisment advertisment)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Saving advertiment");
            int newId = ++id;
            storage.Add(newId, advertisment);
            return newId;
            }

        public void Update(int advertismentId, IAdvertisment advertisment)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Updating advertisment");
            if (storage.ContainsKey(advertismentId))
                storage[advertismentId] = advertisment;
            }
        }
    }
