using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetKeywordsEndpoint : Endpoint
    {
        public MoviesGetKeywordsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "keywords") { }
    }
}
