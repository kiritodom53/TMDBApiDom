using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetKeywordsEndpoint : Endpoint
    {
        public TvGetKeywordsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "keywords") { }
    }
}
