namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioCampaign : ICampaign
        {
        public string Type { get; set; }
        public int AdLength { get; set; }

        public RadioCampaign(string type, int length)
            {
            Type = type;
            AdLength = length;
            }

        public bool ShouldExtendAdvertisment()
            {
            return false;
            }
        }
    }
