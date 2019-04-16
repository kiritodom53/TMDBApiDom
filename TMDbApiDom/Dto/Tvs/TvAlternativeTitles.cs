using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Tvs
{
	public class TvAlternativeTitles
	{
		public int id { get; set; }
		public AlternativeTitleResult[] results { get; set; }
	}
}
