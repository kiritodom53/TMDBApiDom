using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetContentRatingsEndpoint : Endpoint
    {
        public TvGetContentRatingsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "content_ratings") { }
    }
}
