using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.CommerceApi.Request
{
	public class SearchSuggestion
	{
			public string system { get; set; }
			public string language { get; set; }
			public string soldTo { get; set; }
			public string searchQuery { get; set; }
			public string productCount { get; set; }
			public string categoryCount { get; set; }
			public string needProducts { get; set; }
			public string needCategories { get; set; }
	}
}
