namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioCampaign : ICampaign
        {
        public string Type { get; set; }
        public int Length { get; set; }

        public RadioCampaign(string type, int length)
            {
            Type = type;
            Length = length;
            }
        }
    }
