using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetVideosEndpoint : Endpoint
    {
        public TvGetVideosEndpoint(int tv_id) : base("tv", tv_id.ToString(), "videos") { }
    }
}
