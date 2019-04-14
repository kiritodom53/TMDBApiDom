using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Lists
{
    public class ListsDeleteListEndpoint : Endpoint
    {
        public ListsDeleteListEndpoint(int list_id) : base("list", list_id.ToString()) { }
    }
}
