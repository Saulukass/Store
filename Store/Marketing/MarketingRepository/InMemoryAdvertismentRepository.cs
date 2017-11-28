using Store.Marketing.MarketingFacadeService;
using Store.Marketing.MarketingDomainEntities;
using System.Collections.Generic;

namespace Store.Marketing.MarketingRepository
    {
    class InMemoryAdvertismentRepository : IAdvertismentRepository
        {
        Dictionary<int, IAdvertisment> storage;
        static int id = 0;

        public void Delete(int advertismentId)
            {
            storage.Remove(advertismentId);
            }

        public IAdvertisment Get(int advertismentId)
            {
            return storage[advertismentId];
            }

        public int Save(IAdvertisment advertisment)
            {
            int newId = ++id;
            storage.Add(newId, advertisment);
            return newId;
            }

        public void Update(int advertismentId, IAdvertisment advertisment)
            {
            storage[advertismentId] = advertisment;
            }
        }
    }
