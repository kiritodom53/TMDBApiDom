using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetLatestEndpoint : Endpoint
    {
        public PeopleGetLatestEndpoint() : base("person", "latest") { }
    }
}
