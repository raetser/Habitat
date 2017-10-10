using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Response.partials
{
	public class Facet
	{
		public string code { get; set; }
		public string label { get; set; }
		public List<FacetValue> values { get; set; }
	}
}
