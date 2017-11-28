namespace Store.Marketing.MarketingDomainEntities
    {
    class TVAdvertisment : IAdvertisment
        {
        public string Message { get; set; }
        public int CampaignId { get; set; }

        public TVAdvertisment(string message, int campaignId)
            {
            Message = message;
            CampaignId = campaignId;
            }

        }
    }
