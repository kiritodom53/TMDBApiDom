using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto;

namespace TMDbApiDom.Endpoints.Trending
{
    public class TrendingGetTrendingEndpoint : Endpoint
    {
        public TrendingGetTrendingEndpoint(MediaType media_type, TimeWindow time_window) : base("trending", media_type.type, time_window.time) { }
    }
}
