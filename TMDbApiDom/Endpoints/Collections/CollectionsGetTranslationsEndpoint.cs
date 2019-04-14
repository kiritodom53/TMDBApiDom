using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Collections
{
    public class CollectionsGetTranslationsEndpoint : Endpoint
    {
        public CollectionsGetTranslationsEndpoint(int collection_id) : base("collection", collection_id.ToString(), "translations") { }
    }
}
