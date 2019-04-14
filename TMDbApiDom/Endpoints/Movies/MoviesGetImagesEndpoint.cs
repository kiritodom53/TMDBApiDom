using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetImagesEndpoint : Endpoint
    {
        public MoviesGetImagesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "images") { }
    }
}
