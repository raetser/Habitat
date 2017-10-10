using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class GetCartResponse
    {
        public string status { get; set; }
        public Cart cart { get; set; }
    }
}