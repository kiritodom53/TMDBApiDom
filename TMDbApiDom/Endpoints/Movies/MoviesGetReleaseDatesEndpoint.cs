using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetReleaseDatesEndpoint : Endpoint
    {
        public MoviesGetReleaseDatesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "release_dates") { }
    }
}
