using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Tvs
{
	public class TvExternalID
	{
		public string imdb_id { get; set; }
		public string freebase_mid { get; set; }
		public string freebase_id { get; set; }
		public string tvdb_id { get; set; }
		public string tvrage_id { get; set; }
		public string facebook_id { get; set; }
		public string instagram_id { get; set; }
		public string twitter_id { get; set; }
		public int id { get; set; }
	}
}
