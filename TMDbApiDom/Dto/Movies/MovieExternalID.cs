using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieExternalID
    {
        public string imdb_id { get; set; }
        public string facebook_id { get; set; }
        public string instagram_id { get; set; }
        public string twitter_id { get; set; }
        public int id { get; set; }
    }
}
