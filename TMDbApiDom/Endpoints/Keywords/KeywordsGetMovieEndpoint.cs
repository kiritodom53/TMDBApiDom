using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Keywords
{
    public class KeywordsGetMovieEndpoint : Endpoint
    {
        public KeywordsGetMovieEndpoint(int keyword_id) : base("keyword", keyword_id.ToString(), "movies") { }
    }
}
