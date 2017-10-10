using System.Collections.Generic;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class GetFavoritesResponse
    {
        public string status { get; set; }
        public string currencyIsoCode { get; set; }
        public List<FavoritesEntry> entries { get; set; }
        public int totalResults { get; set; }
        public int totalPages { get; set; }
        public Facet[] facets { get; set; }
        public List<SortMode> sortModes { get; set; }

        public GetFavoritesResponse()
        {
            entries = new List<FavoritesEntry>();
            sortModes = new List<SortMode>();
        }
    }

    public class FavoritesEntry
    {
        public string sku { get; set; }
        public int preferredQuantity { get; set; }
        public float basePrice { get; set; }
        public float baseFromPrice { get; set; }
        public bool inStock { get; set; }
        public int inBasket { get; set; }
        public bool onPromotion { get; set; }
    }
    
    public class Facet
    {
        public string code { get; set; }
        public string label { get; set; }
        public Value[] values { get; set; }
    }

    public class Value
    {
        public string code { get; set; }
        public string label { get; set; }
        public bool selected { get; set; }
        public int count { get; set; }
    }
}