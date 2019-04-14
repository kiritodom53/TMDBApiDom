using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Networks
{
    public class NetworksGetAlternativeNamesEndpoint : Endpoint
    {
        public NetworksGetAlternativeNamesEndpoint(int network_id) : base("network", network_id.ToString(), "alternative_names") { }
    }
}
