using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carlsberg.Foundation.Models.CommerceApi.Response.partials;

namespace Carlsberg.Foundation.Models.CommerceApi.Response
{
	public class PromotionListResponse
	{
		public string status { get; set; }
		public string totalPages { get; set; }
		public string totalResults { get; set; }
		public List<Facet> facets { get; set; }
		public List<SortMode> sortModes { get; set; }
		public List<Campaign> campaignList { get; set; }
	}
}
