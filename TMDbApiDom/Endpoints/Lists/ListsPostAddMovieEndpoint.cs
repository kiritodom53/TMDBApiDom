using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Lists
{
    public class ListsPostAddMovieEndpoint : Endpoint
    {
        public ListsPostAddMovieEndpoint(int list_id) : base("list", list_id.ToString(), "add_item") { }
    }
}
