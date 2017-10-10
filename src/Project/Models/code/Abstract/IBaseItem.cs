using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Data;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carlsberg.Foundation.Models.Abstract
{
	public interface IBaseItem
	{
		[SitecoreId]
		ID Id { get; set; }
		string Url { get; set; }

		[SitecoreInfo(SitecoreInfoType.DisplayName)]
		string DisplayName { get; set; }

		[SitecoreInfo(SitecoreInfoType.Language)]
		Language Language { get; set; }

		[SitecoreInfo(SitecoreInfoType.Version)]
		int Version { get; set; }
	}
}
