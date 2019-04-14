using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetTranslationsEndpoint : Endpoint
    {
        public TvGetTranslationsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "translations") { }
    }
}
