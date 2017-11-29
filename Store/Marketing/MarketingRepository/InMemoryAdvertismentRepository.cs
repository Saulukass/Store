using Store.Marketing.MarketingFacadeService;
using Store.Marketing.MarketingDomainEntities;
using System.Collections.Generic;

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
            storage.Remove(advertismentId);
            }

        public IAdvertisment Find(int advertismentId)
            {
            if (storage.ContainsKey(advertismentId))
                return storage[advertismentId];
            return null;
            }

        public int Save(IAdvertisment advertisment)
            {
            int newId = ++id;
            storage.Add(newId, advertisment);
            return newId;
            }

        public void Update(int advertismentId, IAdvertisment advertisment)
            {
            if (storage.ContainsKey(advertismentId))
                storage[advertismentId] = advertisment;
            }
        }
    }
