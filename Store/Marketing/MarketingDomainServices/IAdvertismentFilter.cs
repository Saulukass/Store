using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingDomainServices
    {
    public interface IAdvertismentFilter
        {
        void FilterAdvertisment(IAdvertisment advertisment);
        }
    }
