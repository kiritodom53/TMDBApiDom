using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Genres
{
    public class GenresGetMovieListEndpoint : Endpoint
    {
        public GenresGetMovieListEndpoint() : base("genre", "movie", "list")
        {

        }
    }
}
