using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class DeleteSessionEndpoint : Endpoint
    {
        public DeleteSessionEndpoint() : base("authentication", "session") { }
    }
}
