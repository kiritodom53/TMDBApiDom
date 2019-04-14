using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetExternalIDsEndpoint : Endpoint
    {
        public MoviesGetExternalIDsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "external_ids") { }
    }
}
