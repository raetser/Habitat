using System.Collections.Generic;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class UpdateCartResponse
    {
        public UpdateCartResponse()
        {
            newPromotions = new List<string>();
            deletedPromotions = new List<string>();
            updatedPromotions = new List<string>();
        }

        public string status { get; set; }
        public Cart cart { get; set; }
        public List<string> newPromotions { get; set; }
        public List<string> deletedPromotions { get; set; }
        public List<string> updatedPromotions { get; set; }
        public bool tradeQuotationsRewardLost { get; set; }
        public List<string> newTradeQuotationsRewardsAvailable { get; set; }
    }
}