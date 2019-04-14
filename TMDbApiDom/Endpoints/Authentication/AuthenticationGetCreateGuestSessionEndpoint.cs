using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class AuthenticationGetCreateGuestSessionEndpoint : Endpoint
    {
        public AuthenticationGetCreateGuestSessionEndpoint() : base("authentication", "guest_session", "new") { }
    }
}
