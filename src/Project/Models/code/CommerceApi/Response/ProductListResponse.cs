using System.Collections.Generic;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class ProductListResponse
    {
        public string status { get; set; }
        public uint totalPages { get; set; }
        public uint totalResults { get; set; }
        public string currencyIsoCode { get; set; }
        public string category { get; set; }
        public List<SortMode> sortModes { get; set; }
        public List<Product> productList { get; set; }
        public List<Facet> facets { get; set; }
        public string collations { get; set; }
        public string searchSuggestionMessage { get; set; }
    }
}