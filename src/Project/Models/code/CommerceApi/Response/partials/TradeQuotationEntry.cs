using System.Collections.Generic;
using Castle.Components.DictionaryAdapter;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class TradeQuotationCartEntry
    {

        public string quotationNumber { get; set; }
        public string quotationDescription { get; set; }
        public int percentage { get; set; }

        public List<TradeQuotationCartCampaign> campaigns { get; set; }

        public TradeQuotationCartEntry()
        {
            campaigns = new List<TradeQuotationCartCampaign>();
        }
    }


    public class TradeQuotationCartCampaign
    {
        public string campaignId { get; set; }
        public string campaignDescription { get; set; }
        public List<TradeQuotationCartProduct> entries { get; set; }

        public TradeQuotationCartCampaign()
        {
            entries = new List<TradeQuotationCartProduct>();
        }
    }
}