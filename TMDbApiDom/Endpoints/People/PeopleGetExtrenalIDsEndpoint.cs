using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetExtrenalIDsEndpoint : Endpoint
    {
        public PeopleGetExtrenalIDsEndpoint(int person_id) : base("person", person_id.ToString(), "external_ids") { }
    }
}
