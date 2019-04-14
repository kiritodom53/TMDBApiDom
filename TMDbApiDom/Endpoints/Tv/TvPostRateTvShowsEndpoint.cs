using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvPostRateTvShowsEndpoint : Endpoint
    {
        public TvPostRateTvShowsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "rating") { }
    }
}
