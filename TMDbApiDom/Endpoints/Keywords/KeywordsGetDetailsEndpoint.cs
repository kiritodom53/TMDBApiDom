using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Keywords
{
    public class KeywordsGetDetailsEndpoint : Endpoint
    {
        public KeywordsGetDetailsEndpoint(int keyword_id) : base("keyword", keyword_id.ToString()) { }
    }
}
