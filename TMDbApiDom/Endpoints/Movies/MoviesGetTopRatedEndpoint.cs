using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetTopRatedEndpoint : Endpoint
    {
        public MoviesGetTopRatedEndpoint() : base("movie", "top_rated") { }
    }
}
