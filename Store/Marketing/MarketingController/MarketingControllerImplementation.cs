using Store.Marketing.MarketingFacadeService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Marketing.MarketingController
    {
    public class MarketingControllerImplementation : IMarketingController
        {
        IMarketingFacade facade;

        public MarketingControllerImplementation(IMarketingFacade facade)
            {
            this.facade = facade;
            }

        public int AddAdvertisment(int campaignId, string message)
            {
            return facade.AddAdvertisment(campaignId, message);
            }

        public int AddCampaign(int length, string type)
            {
            return facade.AddCampaign(length, type);
            }

        public int CancelAdvertisment(int advertismentId)
            {
            return facade.CancelAdvertisment(advertismentId);
            }
        }
    }
