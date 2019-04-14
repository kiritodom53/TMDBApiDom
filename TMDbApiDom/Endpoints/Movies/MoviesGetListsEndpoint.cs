using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetListsEndpoint : Endpoint
    {
        public MoviesGetListsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "lists") { }
    }
}
