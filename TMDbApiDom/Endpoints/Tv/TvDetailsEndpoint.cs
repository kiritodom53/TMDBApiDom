using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Tv
{
    class TvDetailsEndpoint : Endpoint
    {
        public TvDetailsEndpoint(int id) : base("tv", id.ToString())
        {

        }
    }
}
