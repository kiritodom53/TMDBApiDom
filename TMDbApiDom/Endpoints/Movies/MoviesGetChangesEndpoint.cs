using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetChangesEndpoint : Endpoint
    {
        public MoviesGetChangesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "changes")
        {
        }
    }
}
