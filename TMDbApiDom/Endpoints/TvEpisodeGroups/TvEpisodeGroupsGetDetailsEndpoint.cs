using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.TvEpisodeGroups
{
    public class TvEpisodeGroupsGetDetailsEndpoint : Endpoint
    {
        public TvEpisodeGroupsGetDetailsEndpoint(int id) : base("tv", "episode_group", id.ToString())
        {

        }
    }
}
