using System.Net.Http;

namespace Carlsberg.Foundation.Models.CommerceApi
{
    public class ApiSettings
    {
        public string Endpoint { get; set; }
        public HttpMethod HttpMethod { get; set; }
        public bool Cachable { get; set; }
        public bool SafeToLogRequest { get; set; }
    }
}