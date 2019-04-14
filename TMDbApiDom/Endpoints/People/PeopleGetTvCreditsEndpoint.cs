using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetTvCreditsEndpoint : Endpoint
    {
        public PeopleGetTvCreditsEndpoint(int person_id) : base("person", person_id.ToString(), "tv_credits") { }
    }
}
