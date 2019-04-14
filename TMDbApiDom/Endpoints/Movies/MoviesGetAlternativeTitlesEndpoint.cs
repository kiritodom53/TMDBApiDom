using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetAlternativeTitlesEndpoint : Endpoint
    {
        public MoviesGetAlternativeTitlesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "alternative_titles")
        {
        }
    }
}
