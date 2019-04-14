using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetTranslationsEndpoint : Endpoint
    {
        public PeopleGetTranslationsEndpoint(int person_id) : base("person", person_id.ToString(), "translations") { }
    }
}
