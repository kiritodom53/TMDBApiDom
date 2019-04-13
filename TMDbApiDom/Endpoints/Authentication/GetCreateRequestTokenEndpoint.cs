using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Authentication
{
    public class GetCreateRequestTokenEndpoint : Endpoint
    {
        public GetCreateRequestTokenEndpoint() : base("authentication", "token", "new")
        {

        }
    }
}
