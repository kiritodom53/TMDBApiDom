using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Collections
{
    public class CollectionsGetImagesEndpoint : Endpoint
    {
        public CollectionsGetImagesEndpoint(int collection_id) : base("collection", collection_id.ToString(), "images") { }
    }
}
