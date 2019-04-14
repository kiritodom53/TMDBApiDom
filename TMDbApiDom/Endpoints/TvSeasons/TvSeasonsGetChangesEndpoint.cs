using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.TvSeasons
{
    public class TvSeasonsGetChangesEndpoint : Endpoint
    {
        public TvSeasonsGetChangesEndpoint(int season_id) : base("tv", "season", season_id.ToString(), "changes") { }
    }
}
