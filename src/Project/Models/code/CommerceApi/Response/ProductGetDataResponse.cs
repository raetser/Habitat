namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class ProductGetDataResponse
    {
        public string status { get; set; }
        public Sku[] skus { get; set; }
        public string currencyIsoCode { get; set; }

        public ProductPromotion productPromotion { get; set; }
    }

    public class Sku
    {
        public string brand { get; set; } //for enrichment purpose
        public string categoryId { get; set; } //for enrichment purpose
        public string name { get; set; } //for enrichment purpose
        public string sku { get; set; }
        public bool inStock { get; set; }
        public bool isFavourite { get; set; }
        public string inBasket { get; set; }
        public string campaignID { get; set; }
        public Price price { get; set; }
        public Relatedproduct[] relatedProducts { get; set; }
        public int deliveryUnit { get; set; }
        public bool onPromotion { get; set; }
    }

    public class Price
    {
        public string currencyIsoCode { get; set; }

        public string price { get; set; }
        public string fromPrice { get; set; }

        public string priceFormatted { get; set; }
        public string fromPriceFormatted { get; set; }
    }

    public class Relatedproduct
    {
        public string type { get; set; }
        public string[] skus { get; set; }
    }

    public class ProductPromotion
    {
        public string imageurl { get; set; }
        public string description { get; set; }
        public string promotionurl { get; set; }
        public string promotionId { get; set; }
    }
}