using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetAccountStatesEndpoint : Endpoint
    {
        public TvGetAccountStatesEndpoint(int tv_id) : base("tv", tv_id.ToString(), "account_states") { }
    }
}
