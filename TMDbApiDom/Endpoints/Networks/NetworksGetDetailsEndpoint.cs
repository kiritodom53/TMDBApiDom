using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Networks
{
    public class NetworksGetDetailsEndpoint : Endpoint
    {
        public NetworksGetDetailsEndpoint(int network_id) : base("network", network_id.ToString()) { }
    }
}
