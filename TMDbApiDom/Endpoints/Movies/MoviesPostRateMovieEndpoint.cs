using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesPostRateMovieEndpoint : Endpoint
    {
        public MoviesPostRateMovieEndpoint(int movie_id) : base("movie", movie_id.ToString(), "rating") { }
    }
}
