using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MoviesGetImagesEndpoint : Endpoint
    {
        public MoviesGetImagesEndpoint(int id) : base("movie", id.ToString(), "images")
        {
        }
    }
}
