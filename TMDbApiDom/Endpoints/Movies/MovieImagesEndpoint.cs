using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Movies
{
    public class MovieImagesEndpoint : Endpoint
    {
        public MovieImagesEndpoint(int id) : base ("movie", id.ToString(), "images")
        {
        }
    }
}
