using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetExternalIDsEndpoint : Endpoint
    {
        public TvGetExternalIDsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "external_ids") { }
    }
}
