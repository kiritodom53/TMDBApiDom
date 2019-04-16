using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.SidewayClasses.SubClasses
{
	public class TranslationObject<T>
	{
		public string iso_3166_1 { get; set; }
		public string iso_639_1 { get; set; }
		public string name { get; set; }
		public string english_name { get; set; }
		public T data { get; set; }

	}
}
