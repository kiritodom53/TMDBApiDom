using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MovieVideosEndpoint : Endpoint
    {
        public MovieVideosEndpoint(int id) : base("movie", id.ToString(), "videos")
        {
        }
    }
}
