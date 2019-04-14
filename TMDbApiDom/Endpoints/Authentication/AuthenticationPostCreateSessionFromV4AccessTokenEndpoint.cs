using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    class AuthenticationPostCreateSessionFromV4AccessTokenEndpoint : Endpoint
    {
        public AuthenticationPostCreateSessionFromV4AccessTokenEndpoint() : base("authentication", "session", "convert", "4") { }
    }
}
