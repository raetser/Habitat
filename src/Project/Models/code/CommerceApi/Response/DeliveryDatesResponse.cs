using System;
using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class DeliveryDate
    {
        public DateTime cutoff { get; set; }
        public DateTime deliveryDate { get; set; }
    }

    public class DeliveryDatesResponse
    {
        public string status { get; set; }
        public List<DeliveryDate> deliveryDates { get; set; }
    }
}