using System;
using System.Collections.Generic;
using System.Linq;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class OrderDetailsModel
    {
        public string status { get; set; }
        public OrderDetailsResponse orderDetails { get; set; }
        public List<OrderDetailProduct> products { get; set; }
    }

    public class OrderDetailsResponse
    {
        public string status { get; set; }
        public string currencyIsoCode { get; set; }
        public DateTime orderDate { get; set; }
        public DateTime deliveryDate { get; set; }
        public string type { get; set; }
        public string poReference { get; set; }
        public string orderStatus { get; set; }
        public List<TotalEntry> totals { get; set; }
        public OrderHistoryTotals stronglyTypedTotals { get; set; }
        public OrderDetailsSku[] entries { get; set; }

        //Custom fields
        public string deliveryDateFormatted { get; set; }
        public string orderDateFormatted { get; set; }
        public string orderNumber { get; set; }
    }

    public class OrderDetailsTotals
    {
        public string totalAmount { get; set; }
        public string taxCosts { get; set; }
    }

    public class OrderDetailsSku
    {
        public string sku { get; set; }
        public string productName { get; set; }
        public string price { get; set; }
        public string entryPrice { get; set; }
        public int quantity { get; set; }
        public bool inStock { get; set; }
        public bool isFavourite { get; set; }
        public int inBasket { get; set; }
    }

    public class OrderDetailProduct : Product
    {
        public int quantity { get; set; }
        public string total { get; set; }
        public string totalFormatted { get; set; }
    }


}
