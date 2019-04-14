using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetReviewsEndpoint : Endpoint
    {
        public TvGetReviewsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "reviews") { }
    }
}
