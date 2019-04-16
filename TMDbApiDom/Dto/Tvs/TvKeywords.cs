using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Movies.SubClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Tvs
{
	public class TvKeywords
	{
		public int id { get; set; }
		public Keywords[] results { get; set; }
	}
}
