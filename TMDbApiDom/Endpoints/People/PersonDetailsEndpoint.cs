using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints.People
{
    public class PersonDetailsEndpoint : Endpoint
    {
        public PersonDetailsEndpoint(int id) : base("person", id.ToString())
        {

        }
    }
}
