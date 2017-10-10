using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class ProductGetData
    {
        public string soldTo { get; set; }
        public List<string> skus  { get; set; }
        public string deliveryDate { get; set; }
        public bool needAlternativeProducts { get; set; }
    }

}
