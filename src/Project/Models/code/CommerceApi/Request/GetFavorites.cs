// ReSharper disable InconsistentNaming

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class GetFavoritesRequest
    {
        public string soldTo { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public GetFavoritesMode mode { get; set; }
        public string deliveryDate { get; set; }
        public string system { get; set; }
        public string language { get; set; }
        public string page { get; set; }
        public string pageSize { get; set; }
        public string needFacets { get; set; }
        public QueryParam[] queryParams { get; set; }
		public string sortMode { get; set; }
    }

    public enum GetFavoritesMode
    {
        SIMPLE,
        DETAILED,
    }
    

}