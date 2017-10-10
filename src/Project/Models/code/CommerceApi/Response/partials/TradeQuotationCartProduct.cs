namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class TradeQuotationCartProduct
    {
        public string sku { get; set; }
        public int agreed { get; set; }
        public int remaining { get; set; }
        public int quantity { get; set; }
        public int inBasket { get; set; }
        public string quotationPosition { get; set; }
        public float basePrice { get; set; }
        public float totalPrice { get; set; }
        public bool inStock { get; set; }
        public bool isFavourite { get; set; }
        public bool isReward { get; set; }
    }
}