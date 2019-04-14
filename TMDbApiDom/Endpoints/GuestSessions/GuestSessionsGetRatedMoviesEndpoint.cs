using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.GuestSessions
{
    public class GuestSessionsGetRatedMoviesEndpoint : Endpoint
    {
        public GuestSessionsGetRatedMoviesEndpoint(int guest_session_id) : base ("guest_session", guest_session_id.ToString(), "rated", "movies") { }
    }
}
