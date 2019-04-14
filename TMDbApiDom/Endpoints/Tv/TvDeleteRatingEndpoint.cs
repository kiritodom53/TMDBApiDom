using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvDeleteRatingEndpoint : Endpoint
    {
        public TvDeleteRatingEndpoint(int tv_id) : base("tv", tv_id.ToString(), "rating") { }
    }
}
