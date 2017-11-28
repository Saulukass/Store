namespace Store.Marketing.MarketingDomainEntities
    {
    class TVCampaign : ICampaign
        {
        public string Type { get; set; }
        public int Length { get; set; }

        public TVCampaign(string type, int length)
            {
            Type = type;
            Length = length;
            }
        }
    }
