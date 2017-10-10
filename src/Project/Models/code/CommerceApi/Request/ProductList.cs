using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
	public class ProductList
	{
		public string system { get; set; }
		public string selector { get; set; }
		public string language { get; set; }
		public string soldTo { get; set; }
		public string searchQuery { get; set; }
		public string sortMode { get; set; }
		public string page { get; set; }
		public string pageSize { get; set; }
		public bool needFacets { get; set; }
		public List<QueryParam> queryParams { get; set; }
        public string categoryId { get; set; }
	    public string deliveryDate { get; set; }
	}
}
