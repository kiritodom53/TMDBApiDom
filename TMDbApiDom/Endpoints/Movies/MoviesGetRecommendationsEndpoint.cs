using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetRecommendationsEndpoint : Endpoint
    {
        public MoviesGetRecommendationsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "recommendations") { }
    }
}
