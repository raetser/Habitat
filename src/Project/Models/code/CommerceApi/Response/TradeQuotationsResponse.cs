using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class TradeQuotationsResponse
    {
        public string status { get; set; }
        public List<TradeQuotationEntry> entries { get; set; }
    }

    public class TradeQuotationEntry
    {
        public string quotationNumber { get; set; }
        public DateTime validFrom { get; set; }
        public string validFromFormatted { get; set; }
        public DateTime validTo { get; set; }
        public string validToFormatted { get; set; }
        public string description { get; set; }
        public int percentage { get; set; }
        public string quotationType { get; set; }
        public string quotationTypeLabel { get; set; }
        public TradeQuotationCampaign[] campaigns { get; set; }
    }

    public class TradeQuotationCampaign
    {
        public string code { get; set; }
        public string description { get; set; }
        public List<TradeQuotationProduct> skus { get; set; }
        public List<TradeQuotationProduct> rewards { get; set; }
    }

    public class TradeQuotationProduct : Product
    {
        public int agreed { get; set; }
        public int remaining { get; set; }
        public string quotationPosition { get; set; }
        public bool isReward { get; set; }
        public string quotationNumber { get; set; }
    }


}
