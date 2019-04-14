using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetUpcomingEndpoint : Endpoint
    {
        public MoviesGetUpcomingEndpoint() : base("movie", "upcoming") { }
    }
}
