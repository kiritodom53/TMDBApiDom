using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MovieSimilarMoviesEndpoint : Endpoint
    {
        public MovieSimilarMoviesEndpoint(int movie_id) : base("movie", movie_id.ToString(), "similar")
        {

        }
    }
}
