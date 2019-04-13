using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetDetailsEndpoint : Endpoint
    {
        public MoviesGetDetailsEndpoint(int id) : base("movie", id.ToString())
        {
        }
    }
}
