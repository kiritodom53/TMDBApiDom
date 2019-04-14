using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetCreditsEndpoint : Endpoint
    {
        public TvGetCreditsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "credits") { }
    }
}
