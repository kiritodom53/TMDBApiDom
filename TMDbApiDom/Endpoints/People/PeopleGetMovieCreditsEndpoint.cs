using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.People
{
    public class PeopleGetMovieCreditsEndpoint : Endpoint
    {
        public PeopleGetMovieCreditsEndpoint(int person_id) : base("person", person_id.ToString(), "movie_credits") { }
    }
}
