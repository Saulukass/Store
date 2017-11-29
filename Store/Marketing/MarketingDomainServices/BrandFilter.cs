using System;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingDomainServices
    {
    public class BrandFilter : IAdvertismentFilter
        {
        public void FilterAdvertisment(IAdvertisment advertisment)
            {
            Console.WriteLine("[" + this.GetType().ToString() + "]" + " Filtering advertisment from other brands mentioning");
            }
        }
    }
