using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
	public class Campaign
	{
		public string id { get; set; }

		public string sitecoreid { get; set; }

		public string promotionname { get; set; }

		public string promotiondescription { get; set; }

		public string promotiontype { get; set; }

		public string promotionstatus { get; set; }

		public DateTime promotionvalidfrom { get; set; }

		public DateTime promotionvalidto { get; set; }

		public string promotiontargetgroupid { get; set; }

		public string imageurl { get; set; }

		public string promotionvalidtotext { get; set; }

		public string url { get; set; }
		public string color { get; set; }
	}
}
