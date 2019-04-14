using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetSimilarMoviesEndpoint : Endpoint
    {
        public MoviesGetSimilarMoviesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "similar") { }
    }
}
