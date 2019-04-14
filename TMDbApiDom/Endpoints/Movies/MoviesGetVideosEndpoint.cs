using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetVideosEndpoint : Endpoint
    {
        public MoviesGetVideosEndpoint(int movie_id) : base("movie", movie_id.ToString(), "videos") { }
    }
}
