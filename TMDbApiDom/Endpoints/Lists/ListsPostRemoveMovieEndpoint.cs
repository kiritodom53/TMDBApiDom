using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Lists
{
    public class ListsPostRemoveMovieEndpoint : Endpoint
    {
        public ListsPostRemoveMovieEndpoint(int list_id) : base("list", list_id.ToString(), "remove_item") { }
    }
}
