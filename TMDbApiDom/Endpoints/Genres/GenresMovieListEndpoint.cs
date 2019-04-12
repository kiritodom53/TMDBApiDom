using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Genres
{
    public class GenresMovieListEndpoint : Endpoint
    {
        public GenresMovieListEndpoint() : base("genre", "movie", "list")
        {
            
        }
    }
}
