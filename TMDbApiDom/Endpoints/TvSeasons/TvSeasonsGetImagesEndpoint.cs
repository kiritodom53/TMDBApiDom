using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.TvSeasons
{
    public class TvSeasonsGetImagesEndpoint : Endpoint
    {
        public TvSeasonsGetImagesEndpoint(int tv_id, int season_number) : base("tv", tv_id.ToString(), "season", season_number.ToString(), "images") { }
    }
}
