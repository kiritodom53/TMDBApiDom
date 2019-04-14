using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetLatestEndpoint : Endpoint
    {
        public TvGetLatestEndpoint(int tv_id) : base("tv", "latest") { }
    }
}
