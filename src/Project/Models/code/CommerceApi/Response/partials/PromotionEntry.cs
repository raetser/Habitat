using System;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class PromotionEntry
    {
        public string id { get; set; }
        public string Message { get; set; }
        public string[] qualifyingProducts { get; set; }
        public RewardEntry[] reward { get; set; }
        public int maxRewardQuantity { get; set; }
        public int? nextTieredDealRewardQuantity { get; set; }
        public int? nextTieredDealQualifyingQuantity { get; set; }
		public double? nextTieredDealQualifyingQuantityLiters { get; set; }
		public int? nextTieredDealLevel { get; set; }
    }

    public class RewardEntry
    {
        public string sku { get; set; }
        public int quantity { get; set; }
    }
}