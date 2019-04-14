using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetRecommendationsEndpoint : Endpoint
    {
        public TvGetRecommendationsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "recommendations") { }
    }
}
