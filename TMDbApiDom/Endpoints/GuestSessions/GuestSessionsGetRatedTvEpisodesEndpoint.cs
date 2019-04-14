using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.GuestSessions
{
    public class GuestSessionsGetRatedTvEpisodesEndpoint : Endpoint
    {
        public GuestSessionsGetRatedTvEpisodesEndpoint(int guest_session_id) : base("guest_session", guest_session_id.ToString(), "rated", "tv", "episodes") { }
    }
}
