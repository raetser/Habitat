using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class ChangePassword
    {
        public string token { get; set; }
        public string newpassword { get; set; }
    }

}
