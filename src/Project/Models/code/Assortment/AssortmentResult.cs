using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.Assortment
{
    public class AssortmentResult
    {
        public List<string> AssortmentCategories { get; set; }
        public List<string> AssortmentProducts { get; set; }
        public List<string> AssortmentCampaigns { get; set; }
        public List<string> AssortmentTradeQuotations { get; set; }
        public bool AllowedAllAssortment { get; set; }
    }
}