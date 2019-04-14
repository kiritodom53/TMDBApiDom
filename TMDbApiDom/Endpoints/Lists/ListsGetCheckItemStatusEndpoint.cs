using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Lists
{
    public class ListsGetCheckItemStatusEndpoint : Endpoint
    {
        public ListsGetCheckItemStatusEndpoint(int list_id) : base("list", list_id.ToString(), "item_status") { }
    }
}
