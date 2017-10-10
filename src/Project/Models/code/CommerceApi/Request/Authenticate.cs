using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class Authenticate
    {
        public string username { get; set; }
        public string password { get; set; }
    }
}
