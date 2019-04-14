using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.TvEpisodes
{
    public class TvEpisodesPostRateTvEpisode : Endpoint
    {
        public TvEpisodesPostRateTvEpisode(int tv_id, int season_number, int episode_number) : base("tv", tv_id.ToString(), "season", season_number.ToString(), "episode", episode_number.ToString(), "rating")
        {

        }
    }
}
