using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetPopularEndpoint : Endpoint
    {
        public MoviesGetPopularEndpoint() : base("movie", "popular") { }
    }
}
