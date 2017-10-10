using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class Cart
    {
        public string cartId { get; set; }
        public string currencyIsoCode { get; set; }
        public int totalDistinctProducts { get; set; }
        public List<TotalEntry> totals { get; set; }
        public int totalProducts { get; set; }
        public List<ProductEntries> entries { get; set; }
        public List<PromotionEntry> appliedPromotions { get; set; }
        public List<PromotionEntry> firedPromotions { get; set; }
        public List<PromotionEntry> potentialPromotions { get; set; }
        public List<TradeQuotationCartEntry> tradeQuotationCartEntries { get; set; }

        public Cart()
        {
            entries = new List<ProductEntries>();
            appliedPromotions = new List<PromotionEntry>();
            firedPromotions = new List<PromotionEntry>();
            potentialPromotions = new List<PromotionEntry>();
            tradeQuotationCartEntries = new List<TradeQuotationCartEntry>();
            totals = new List<TotalEntry>();
        }
    }
}