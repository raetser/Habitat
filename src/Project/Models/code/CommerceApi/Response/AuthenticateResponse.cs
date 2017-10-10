using System.Collections.Generic;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class AuthenticateResponse
    {
        public string status { get; set; }
        public List<Message> messages { get; set; }
    }
}
