using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetEpisodeGroupsEndpoint : Endpoint
    {
        public TvGetEpisodeGroupsEndpoint(int tv_id) : base("tv", tv_id.ToString(), "episode_groups") { }
    }
}
