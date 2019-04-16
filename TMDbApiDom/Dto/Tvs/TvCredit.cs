using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Tvs
{
	public class TvCredit
	{
		public int id { get; set; }
		public Cast[] cast { get; set; }
		public Crew[] crew { get; set; }
	}
}
