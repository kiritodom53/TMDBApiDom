using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class AuthenticationGetCreateRequestTokenEndpoint : Endpoint
    {
        public AuthenticationGetCreateRequestTokenEndpoint() : base("authentication", "token", "new")
        {

        }
    }
}
