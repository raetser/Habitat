using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
    public class ChangePasswordResponse
    {
        public string status { get; set; }
        public Message[] messages { get; set; }
    }
}
