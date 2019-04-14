using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.TvEpisodes
{
    public class TvEpisodesGetChangesEndpoint : Endpoint
    {
        public TvEpisodesGetChangesEndpoint(int episode_id) : base("tv", "episode", episode_id.ToString(), "changes") { }
    }
}
