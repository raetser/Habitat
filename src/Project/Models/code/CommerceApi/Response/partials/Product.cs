using System;
using Glass.Mapper.Sc;
using Sitecore;
using Sitecore.Data;
using Sitecore.Links;
using Sitecore.Diagnostics;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
    public class Product
    {
        public string id { get; set; }
        public string sku { get; set; }
        public string price { get; set; }
        public string fromPrice { get; set; }
        public string brand { get; set; }
        public string name { get; set; }
        public string imageurl { get; set; }
        public string packaging { get; set; }
        public string volume { get; set; }
        public string alcoholpercentage { get; set; }
        public int inBasket { get; set; }
        public bool inStock { get; set; }
        public bool isFavourite { get; set; }
        public string currencyIsoCode { get; set; }
        public int deliveryUnit { get; set; }
        public string campaignID { get; set; }
        public string categoryId { get; set; }
        public bool onPromotion { get; set; }
        public bool orderable { get; set; }

        public string producturl
        {
            get
            {
                try
                {
                    var url = string.Empty;
                    Guid itemId;
                    Guid.TryParse(id, out itemId);

                    if (string.IsNullOrEmpty(id) || itemId == Guid.Empty)
                    {
                        return url;
                    }

                    var item = Context.Database.GetItem(new ID(itemId));
                    if (item != null)
                        url = LinkManager.GetItemUrl(item);
                    return url;
                }
                catch (Exception ex)
                {
                    Sitecore.Diagnostics.Log.Error($"Producturl couldn't be resolved for product with id{id}", ex, this);
                }

                return String.Empty;
            }
        }

        public string fromPriceFormatted { get; set; }
        public string priceFormatted { get; set; }
    }
}