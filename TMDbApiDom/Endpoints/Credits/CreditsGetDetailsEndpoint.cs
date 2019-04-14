using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Credits
{
    public class CreditsGetDetailsEndpoint : Endpoint
    {
        public CreditsGetDetailsEndpoint(int credit_id) : base("credit", credit_id.ToString()) { }
    }
}
