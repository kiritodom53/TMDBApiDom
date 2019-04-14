using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesDeleteRatingEndpoint : Endpoint
    {
        public MoviesDeleteRatingEndpoint(int movie_id) : base("movie", movie_id.ToString(), "rating") { }
    }
}
