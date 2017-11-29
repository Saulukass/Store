namespace Store.Marketing.MarketingDomainEntities
    {
    public class TVCampaign : ICampaign
        {
        public string Type { get; set; }
        public int AdLength { get; set; }

        public TVCampaign(string type, int length)
            {
            Type = type;
            AdLength = length;
            }

        public bool ShouldExtendAdvertisment()
            {
            return true;
            }
        }
    }
