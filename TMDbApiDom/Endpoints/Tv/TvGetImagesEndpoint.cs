using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetImagesEndpoint : Endpoint
    {
        public TvGetImagesEndpoint(int tv_id) : base("tv", tv_id.ToString(), "images") { }
    }
}
