using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{

    public class ForgotPasswordTokenResponse
    {
        public string status { get; set; }
        public string token { get; set; }
        public DateTime expires { get; set; }
        public Message[] messages { get; set; }
    }

}
