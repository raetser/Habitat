using System;
using System.Collections.Generic;
using System.Linq;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class OrderHistoryResponse
    {
        public string status { get; set; }
        public OrderHistoryEntry[] entries { get; set; }
    }

    public class OrderHistoryEntry
    {
        public string orderNumber { get; set; }
        public string currencyIsoCode { get; set; }
        public DateTime orderDate { get; set; }
        public string orderDateFormatted { get; set; }
        public DateTime deliveryDate { get; set; }
        public string deliveryDateFormatted { get; set; }
        public string type { get; set; }
        public string poReference { get; set; }
        public string status { get; set; }
        private string _orderStatus; //to be removed after api only returns status
        public string orderStatus { get { return _orderStatus == null ? status : _orderStatus; } set { _orderStatus = value; } }
        public List<TotalEntry> totals { get; set; }
        public OrderHistoryTotals stronglyTypedTotals { get; set; }

    }

    public class OrderHistoryTotals
    {
        public float totalAmount { get; set; }
        public float taxCosts { get; set; }
        public string totalAmountFormatted { get; set; }
        public string taxCostsFormatted { get; set; }
    }

}
