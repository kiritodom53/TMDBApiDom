using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetImagesEndpoint : Endpoint
    {
        public PeopleGetImagesEndpoint(int person_id) : base("person", person_id.ToString(), "images") { }
    }
}
