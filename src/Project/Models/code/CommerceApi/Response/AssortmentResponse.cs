using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
	public class AssortmentResponse
	{
		public List<string> assortmentCategories { get; set; }
		public List<string> assortmentProducts { get; set; }
		public List<string> assortmentCampaigns { get; set; }
		public List<string> assortmentTradeQuotations { get; set; }
        public string allowedAllAssortment { get; set; }
	}
}
