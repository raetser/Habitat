using System.Collections.Generic;
using Newtonsoft.Json;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class OrderHistoryListQuery
    {
        public string fromDate { get; set; }
        public string toDate { get; set; }
    }
}