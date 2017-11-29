namespace Store.Marketing.MarketingDomainEntities
    {
    class TVAdvertisment : IAdvertisment
        {
        private ICampaign _currentCampaign;
        public string Message { get; set; }

        public TVAdvertisment(string message)
            {
            Message = message;
            }

        public bool HasGraphics()
            {
            return true;
            }

        public void ApplyNewCampaign(ICampaign campaign)
            {
            _currentCampaign = campaign;
            }

        public int GetDuration()
            {
            if (null != _currentCampaign)
                {
                int duration = _currentCampaign.AdLength;
                if (_currentCampaign.ShouldExtendAdvertisment())
                    duration = (int)(duration * 1.2);

                return duration;
                }
            return 100;
            }
        }
    }
