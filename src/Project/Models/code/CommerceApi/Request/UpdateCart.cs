using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class UpdateCart
    {
        public string soldTo { get; set; }
        public string mode { get; set; }
        public string deliveryDate { get; set; }
        public List<Updatecartentry> updateCartEntries { get; set; }
        public List<UpdateTradeQuotationsCartEntry> updateTradeQuotationCartEntries { get; set; }

        public UpdateCart()
        {
            //Instead of checking 
            updateCartEntries = new List<Updatecartentry>();
            updateTradeQuotationCartEntries = new List<UpdateTradeQuotationsCartEntry>();
        }
    }

    public class Updatecartentry
    {
        public string sku { get; set; }
        public int? entryNumber { get; set; }
        public int quantity { get; set; }
    }

    public class UpdateTradeQuotationsCartEntry
    {
        public string sku { get; set; }
        public int quantity { get; set; }
        public string quotationPosition { get; set; }
        public string quotationNumber { get; set; }
        public string campaignId { get; set; }
        public bool isReward { get; set; }
    }
}
