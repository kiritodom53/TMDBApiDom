using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetPopularEndpoint : Endpoint
    {
        public PeopleGetPopularEndpoint() : base("person", "popular") { }
    }
}
