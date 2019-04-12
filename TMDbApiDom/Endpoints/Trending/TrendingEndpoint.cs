using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbApiDom.Dto;

namespace TMDbApiDom.Endpoints.Trending
{
    public class TrendingEndpoint : Endpoint
    {
        public TrendingEndpoint(MediaType media_type, TimeWindow time_window) : base("trending", media_type.type, time_window.time)
        {

        }
    }
}
