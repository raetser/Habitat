using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class AddReward
    {
        public string soldTo { get; set; }
        public string promotionId { get; set; }
        public List<AddRewardEntry> rewardEntries { get; set; }
    }

    public class AddRewardEntry
    {
        public string sku { get; set; }
        public int quantity { get; set; }
    }
}