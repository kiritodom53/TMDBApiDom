using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetChangesEndpoint : Endpoint
    {
        public TvGetChangesEndpoint(int tv_id) : base("tv", tv_id.ToString(), "changes") { }
    }
}
