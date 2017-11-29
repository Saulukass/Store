using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Marketing.MarketingController
    {
    public interface IMarketingController
        {
        int AddAdvertisment(int campaignId, string message);
        int AddCampaign(int length, string type);
        int CancelAdvertisment(int advertismentId);
        }
    }
