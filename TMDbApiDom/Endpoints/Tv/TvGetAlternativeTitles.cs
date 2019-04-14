using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetAlternativeTitles : Endpoint
    {
        public TvGetAlternativeTitles(int tv_id) : base("tv", tv_id.ToString(), "alternative_titles") { }
    }
}
