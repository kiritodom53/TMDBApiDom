using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetNowPlayingEndpoint : Endpoint
    {
        public MoviesGetNowPlayingEndpoint() : base("movie", "now_playing") { }
    }
}
