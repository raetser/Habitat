using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
    public class ProductEntries
    {
        public string sku { get; set; }
        public int quantity { get; set; }
        public int minQuantity { get; set; }
        public int maxQuantity { get; set; }
        public int basePrice { get; set; }
        public int baseFromPrice { get; set; }
        public int totalPrice { get; set; }
    }
}
