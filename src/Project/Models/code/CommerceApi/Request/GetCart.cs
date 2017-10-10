namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class GetCart
    {
        public string soldTo { get; set; }
        public string mode { get; set; }
        public bool? recalculateCart { get; set; }
        public bool? atpCheck { get; set; }
        public string deliveryDate { get; set; }
        public bool? salesPrice { get; set; }
        public string deliveryAddressUid { get; set; }
    }
}