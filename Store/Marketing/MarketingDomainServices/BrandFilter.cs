﻿using System;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingDomainServices
    {
    public class BrandFilter : IAdvertismentFilter
        {
        public void FilterAdvertisment(IAdvertisment advertisment)
            {
            string toEdit = advertisment.Message;

            // currently we don't filter other brands
            }
        }
    }
