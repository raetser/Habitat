using System.Collections.Generic;
using Newtonsoft.Json;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class ProductListQuery
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryParam> queryParams { get; set; }

        public string page { get; set; }
        public string sortMode { get; set; }
        public string searchQuery { get; set; }
        public string categoryId { get; set; }
    }
}