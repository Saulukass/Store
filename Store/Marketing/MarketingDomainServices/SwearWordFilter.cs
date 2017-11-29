using System;
using Store.Marketing.MarketingDomainEntities;

namespace Store.Marketing.MarketingDomainServices
    {
    public class SwearWordFilter : IAdvertismentFilter
        {
        static string[] s_badWords = { "BadWord", "SwearWord", "FWord" };
        public void FilterAdvertisment(IAdvertisment advertisment)
            {
            string messageToEdit = advertisment.Message;
            foreach (string badWord in s_badWords)
                messageToEdit.Replace(badWord, "");
            advertisment.Message = messageToEdit;
            }
        }
    }
