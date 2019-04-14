using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Lists
{
    public class ListsPostClearListEndpoint : Endpoint
    {
        public ListsPostClearListEndpoint(int list_id) : base("list", list_id.ToString(), "clear") { }
    }
}
