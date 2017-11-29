namespace Store.Marketing.MarketingDomainEntities
    {
    class RadioAdvertisment : IAdvertisment
        {
        public string Message { get; set; }

        public RadioAdvertisment(string message)
            {
            Message = message;
            }

        public bool HasGraphics()
            {
            return false;
            }

        public void ApplyNewCampaign(ICampaign campaign)
            {
            return;
            }

        public int GetDuration()
            {
            return 100;
            }
        }
    }
