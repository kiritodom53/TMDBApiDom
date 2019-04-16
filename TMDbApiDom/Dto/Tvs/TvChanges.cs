using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Tvs.SubClasses;

namespace TMDbApiDom.Dto.Tvs
{
	public class TvChanges<T>
	{
		public T[] changes { get; set; }
	}
}
