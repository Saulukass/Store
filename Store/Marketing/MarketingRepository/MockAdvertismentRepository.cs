using Store.Marketing.MarketingFacadeService;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingRepository
    {
    class MockAdvertismentRepository : IAdvertismentRepository
        {
        IAdvertisment instance = null;

        public void Delete(int advertismentId)
            {
            return;
            }

        public IAdvertisment Find(int advertismentId)
            {
            if (null != instance)
                return instance;
            return null;
            }

        public int Save(IAdvertisment advertisment)
            {
            instance = advertisment;
            return 1;
            }

        public void Update(int advertismentId, IAdvertisment advertisment)
            {
            return;
            }
        }
    }
