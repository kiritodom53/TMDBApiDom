using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetTaggedImagesEndpoint : Endpoint
    {
        public PeopleGetTaggedImagesEndpoint(int person_id) : base("person", person_id.ToString(), "tagged_images") { }
    }
}
