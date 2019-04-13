using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.SidewayClasses.AbstractClasses;

namespace TMDbApiDom.Dto.Authentication
{
    public class SessionToken
    {
        public bool success { get; set; }
        public string session_id { get; set; }
    }
}
