using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetLatestEndpoint : Endpoint
    {
        public MoviesGetLatestEndpoint() : base("movie", "latest") { }
    }
}
