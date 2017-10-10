using System.Collections.Generic;
using Newtonsoft.Json;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class PromotionProductListQuery
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public List<QueryParam> queryParams { get; set; }

        public string page { get; set; }
        public string campaignId { get; set; }
        public string mode { get; set; }
        public string sortMode { get; set; }
    }
}