using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class PostCreateSessionEndpoint : Endpoint
    {
        public PostCreateSessionEndpoint() : base("authentication", "session", "new") { }
    }
}
