using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
	public class PromotionListQuery
	{
		public string page { get; set; }
		public string pageSize { get; set; }
		public List<QueryParam> queryParams { get; set; }
	}
}
