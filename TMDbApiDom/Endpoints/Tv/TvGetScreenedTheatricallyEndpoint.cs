﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Tv
{
    public class TvGetScreenedTheatricallyEndpoint : Endpoint
    {
        public TvGetScreenedTheatricallyEndpoint(int tv_id) : base("tv", tv_id.ToString(), "screened_theatrically") { }
    }
}
