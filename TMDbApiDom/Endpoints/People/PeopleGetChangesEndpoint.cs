﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetChangesEndpoint : Endpoint
    {
        public PeopleGetChangesEndpoint(int person_id) : base("person", person_id.ToString(), "changes") { }
    }
}
