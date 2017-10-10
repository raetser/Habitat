using System;

namespace Carlsberg.Foundation.Models.DeliveryDates
{
    public class DeliveryDate
    {
        public DateTime UtcCutOff { get; set; }
        public DateTime UtcDeliveryDate { get; set; }
        public DateTime LocalDeliveryDate { get; set; }
        public DateTime LocalCutOff { get; set; }
    }
}