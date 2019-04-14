using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetDetailsEndpoint : Endpoint
    {
        public TvGetDetailsEndpoint(int id) : base("tv", id.ToString()) { }
    }
}
