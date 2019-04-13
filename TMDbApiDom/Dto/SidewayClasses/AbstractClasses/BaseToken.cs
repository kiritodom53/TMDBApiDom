using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.SidewayClasses.AbstractClasses
{
    public abstract class BaseToken
    {
        public bool success { get; set; }
        public string expires_at { get; set; }
        public string request_token { get; set; }
    }
}
