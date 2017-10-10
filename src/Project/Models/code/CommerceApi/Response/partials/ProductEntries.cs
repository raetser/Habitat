namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class ProductEntries
    {
        public string sku { get; set; }
        public int entryNumber { get; set; }
        public int quantity { get; set; }
        public int inBasket { get; set; }
        public int minQuantity { get; set; }
        public int maxQuantity { get; set; }
        public float basePrice { get; set; }
        public float baseFromPrice { get; set; }
        public float totalPrice { get; set; }
        public bool? inStock { get; set; }
        public bool? isFavourite { get; set; }
        public bool? onPromotion { get; set; }
        public string appliedPromotionId { get; set; }
    }
}