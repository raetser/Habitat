namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class TotalEntry
    {
        public string totalCode { get; set; }
        public float totalAmount { get; set; }
    }

    public enum KnownTotalCodes
    {
        totalAmount,
        taxCosts,
        subTotalAmount,
        deliveryCosts
    }
}