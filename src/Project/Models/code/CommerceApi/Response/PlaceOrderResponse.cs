using System;
using System.Collections.Generic;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class PlaceOrderResponse
    {
        public string status { get; set; }
        public Order order { get; set; }
    }

    public class Order
    {
        public string orderNumber { get; set; }
        public string poReference { get; set; }
        public DateTime deliveryDate { get; set; }
        public string deliveryAddressUid { get; set; }
        public int totalProducts { get; set; }
        public int totalDistinctProducts { get; set; }
        public string currencyIsoCode { get; set; }
        public List<TotalEntry> totals { get; set; }
        public Entry[] entries { get; set; }
        public List<TradeQuotationCartEntry> tradeQuotationOrderEntries { get; set; }

        public Order()
        {
            tradeQuotationOrderEntries = new List<TradeQuotationCartEntry>();
            totals = new List<TotalEntry>();
        }
    }

    public class Entry
    {
        public string sku { get; set; }
        public int quantity { get; set; }
        public float basePrice { get; set; }
        public float totalPrice { get; set; }
        public bool onPromotion { get; set; }
        public bool isFavourite { get; set; }
    }
    
}