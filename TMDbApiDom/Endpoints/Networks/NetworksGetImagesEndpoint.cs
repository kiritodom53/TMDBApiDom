﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Networks
{
    public class NetworksGetImagesEndpoint : Endpoint
    {
        public NetworksGetImagesEndpoint(int network_id) : base("network", network_id.ToString(), "images") { }
    }
}
