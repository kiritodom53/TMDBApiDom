using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetCombinedCreditsEndpoint : Endpoint
    {
        public PeopleGetCombinedCreditsEndpoint(int person_id) : base("person", person_id.ToString(), "combined_credits") { }
    }
}
