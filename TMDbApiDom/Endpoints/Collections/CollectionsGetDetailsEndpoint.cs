using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Collections
{
    public class CollectionsGetDetailsEndpoint : Endpoint
    {
        public CollectionsGetDetailsEndpoint(int collection_id) : base("collection", collection_id.ToString()) { }
    }
}
