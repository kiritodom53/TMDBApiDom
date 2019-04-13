using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetVideosEndpoint : Endpoint
    {
        public MoviesGetVideosEndpoint(int id) : base("movie", id.ToString(), "videos")
        {
        }
    }
}
