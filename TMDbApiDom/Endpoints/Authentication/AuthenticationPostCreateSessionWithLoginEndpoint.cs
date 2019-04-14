using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    class AuthenticationPostCreateSessionWithLoginEndpoint : Endpoint
    {
        public AuthenticationPostCreateSessionWithLoginEndpoint() : base("authentication", "token", "validate_with_login") { }
    }
}
