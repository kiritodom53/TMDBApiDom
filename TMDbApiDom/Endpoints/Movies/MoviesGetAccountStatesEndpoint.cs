using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetAccountStatesEndpoint : Endpoint
    {
        public MoviesGetAccountStatesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "account_states")
        {
        }
    }
}
