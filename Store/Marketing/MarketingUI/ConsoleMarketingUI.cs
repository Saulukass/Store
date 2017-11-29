using Store.Marketing.MarketingController;
using System;

namespace Store.Marketing.MarketingUI
    {
    public class ConsoleMarketingUI : IMarketingUI
        {
        IMarketingController controller;

        public ConsoleMarketingUI(IMarketingController controller)
            {
            this.controller = controller;
            }

        public void AddAdvertisment()
            {
            Console.WriteLine("Enter advertisment message: ");
            string message = Console.ReadLine();
            Console.WriteLine("Enter campaign id: ");
            int campaignId = Int32.Parse(Console.ReadLine());

            int advertismentId = controller.AddAdvertisment(campaignId, message);
            if (-1 != advertismentId)
                Console.WriteLine("Advertisment was created with ID -- " + advertismentId);
            }

        public void AddCampaign()
            {
            Console.WriteLine("Enter campaign length: ");
            int length = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter campaign type: ");
            string type = Console.ReadLine();

            int campaignId = controller.AddCampaign(length, type);
            if (-1 != campaignId)
                Console.WriteLine("Campaign was created with ID -- " + campaignId);
            }

        public void CancelAdvertisment()
            {
            Console.WriteLine("Enter advertisment id: ");
            int id = Int32.Parse(Console.ReadLine());

            int cancelledId = controller.CancelAdvertisment(id);
            if (-1 != cancelledId)
                Console.WriteLine("Cancelled advertisment with ID -- " + cancelledId);
            }
        }
    }
