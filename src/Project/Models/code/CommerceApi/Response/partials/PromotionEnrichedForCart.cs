namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class PromotionEnrichedForCart : PromotionEntry
    {
        public PromotionEnrichedForCart(PromotionEntry entry)
        {
            id = entry.id;
            Message = entry.Message;
            qualifyingProducts = entry.qualifyingProducts;
            reward = entry.reward;
            maxRewardQuantity = entry.maxRewardQuantity;
            nextTieredDealLevel = entry.nextTieredDealLevel;
            nextTieredDealQualifyingQuantity = entry.nextTieredDealQualifyingQuantity;
            nextTieredDealRewardQuantity = entry.nextTieredDealRewardQuantity;
	        nextTieredDealQualifyingQuantityLiters = entry.nextTieredDealQualifyingQuantityLiters;
        }

        public string PromotionName { get; set; }
		public string PromotionType { get; set; }
		public string PromotionDescription { get; set; }
        public string PromotionImageUrl { get; set; }
		public string NextTierType { get; set; }
		public string NextTieredDealQualifyingQuantityValue { get; set; }
	}
}