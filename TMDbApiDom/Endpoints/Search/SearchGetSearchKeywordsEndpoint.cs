using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Search
{
    public class SearchGetSearchKeywordsEndpoint : Endpoint
    {
        public SearchGetSearchKeywordsEndpoint() : base("search", "keyword") { }
    }
}
