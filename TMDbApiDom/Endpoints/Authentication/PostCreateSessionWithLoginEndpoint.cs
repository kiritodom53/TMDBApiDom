using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    class PostCreateSessionWithLoginEndpoint : Endpoint
    {
        public PostCreateSessionWithLoginEndpoint() : base("authentication", "token", "validate_with_login") { }
    }
}
