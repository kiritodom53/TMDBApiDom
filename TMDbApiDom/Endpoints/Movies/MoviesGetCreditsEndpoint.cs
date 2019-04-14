using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetCreditsEndpoint : Endpoint
    {
        public MoviesGetCreditsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "credits") { }
    }
}
