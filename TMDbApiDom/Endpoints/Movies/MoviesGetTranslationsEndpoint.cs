using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetTranslationsEndpoint : Endpoint
    {
        public MoviesGetTranslationsEndpoint(int movie_id) : base("movie", movie_id.ToString(), "translations") { }
    }
}
