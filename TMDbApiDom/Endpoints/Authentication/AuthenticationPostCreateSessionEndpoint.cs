using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class AuthenticationPostCreateSessionEndpoint : Endpoint
    {
        public AuthenticationPostCreateSessionEndpoint() : base("authentication", "session", "new") { }
    }
}
