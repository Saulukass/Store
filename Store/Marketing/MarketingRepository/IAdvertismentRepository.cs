using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingRepository
    {
    public interface IAdvertismentRepository
        {
        IAdvertisment Find(int advertismentId);
        int Save(IAdvertisment advertisment);
        void Update(int advertismentId, IAdvertisment advertisment);
        void Delete(int advertismentId);
        }
    }
