using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetSimilarTvShowsEndpoint : Endpoint
    {
        public TvGetSimilarTvShowsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "similar") { }
    }
}
