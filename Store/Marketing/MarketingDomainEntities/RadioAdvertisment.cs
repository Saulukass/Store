namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioAdvertisment : IAdvertisment
        {
        public string Message { get; set; }
        public int CampaignId { get; set; }

        public RadioAdvertisment(string message, int campaignId)
            {
            Message = message;
            CampaignId = campaignId;
            }
        }
    }
