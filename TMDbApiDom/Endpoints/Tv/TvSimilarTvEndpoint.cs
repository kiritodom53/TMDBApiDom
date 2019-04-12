using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvSimilarTvEndpoint : Endpoint
    {

        public TvSimilarTvEndpoint (int tv_id) : base("tv", tv_id.ToString(), "similar")
        {

        }
    }
}
